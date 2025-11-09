var apiBaseUrl = window.location.origin + "/api/";
const EMPLOYEES_API_URL = apiBaseUrl + "employees";
const DEPARTMENTS_API_URL = apiBaseUrl + "departments";

$(document).ready(function () {
    const urlParams = new URLSearchParams(window.location.search);
    const employeeId = urlParams.get('id');
    const departmentId = urlParams.get('departmentId');

    console.log('Employee ID:', employeeId);
    console.log('Department ID:', departmentId);

    if (departmentId && !employeeId) {
        // Если передан departmentId и НЕ передан employeeId - загружаем только этот отдел
        $('#form-title').text('Добавление сотрудника');
        loadSingleDepartment(departmentId);
    } else if (employeeId) {
        // Если передан employeeId - загружаем все отделы для выбора
        $('#form-title').text('Редактирование сотрудника');
        loadDepartments().then(() => {
            loadEmployee(employeeId);
        });
    } else {
        // Если нет параметров - загружаем все отделы
        $('#form-title').text('Добавление сотрудника');
        loadDepartments();
    }

    $('#employee-form').on('submit', function (e) {
        e.preventDefault();
        if (validateEmployeeForm()) {
            saveEmployee();
        }
    });

    $('#cancel-btn').on('click', function () {
        window.location.href = 'employees.html';
    });

    $('#photo').on('change', function (e) {
        handlePhotoUpload(e);
    });

    $('#full-name, #position').on('input', function () {
        validateField($(this));
    });
});

// Загрузка всех отделов (для редактирования)
function loadDepartments() {
    return $.ajax({
        url: DEPARTMENTS_API_URL,
        type: 'GET',
        success: function (departments) {
            const departmentSelect = $('#department-id');
            departmentSelect.empty().append('<option value="">Выберите отдел</option>');

            departments.forEach(department => {
                departmentSelect.append(`<option value="${department.id}">${department.name}</option>`);
            });
            console.log('Все отделы загружены:', departments.length);
        },
        error: function (xhr, status, error) {
            showMessage('Ошибка при загрузке отделов: ' + error, 'error');
        }
    });
}

// Загрузка только одного отдела (для добавления сотрудника в конкретный отдел)
function loadSingleDepartment(departmentId) {
    $.ajax({
        url: `${DEPARTMENTS_API_URL}/${departmentId}`,
        type: 'GET',
        success: function (department) {
            const departmentSelect = $('#department-id');
            departmentSelect.empty(); // Очищаем список

            // Добавляем только один отдел
            departmentSelect.append(`<option value="${department.id}" selected>${department.name}</option>`);
            departmentSelect.prop('disabled', true); // Делаем поле readonly

            console.log('Загружен один отдел:', department.name);
        },
        error: function (xhr, status, error) {
            showMessage('Ошибка при загрузке отдела: ' + error, 'error');
            // Если не удалось загрузить отдел, загружаем все отделы
            loadDepartments();
        }
    });
}

function loadEmployee(employeeId) {
    $.ajax({
        url: `${EMPLOYEES_API_URL}/${employeeId}`,
        type: 'GET',
        success: function (employee) {
            console.log('Данные сотрудника для редактирования:', employee);

            // Заполняем все поля формы
            $('#employee-id').val(employee.id);
            $('#full-name').val(employee.fullName);
            $('#position').val(employee.position);

            // Устанавливаем отдел
            $('#department-id').val(employee.departmentId);
            console.log('Установлен отдел ID:', employee.departmentId);

            // Отображаем фотографию если есть
            if (employee.photo) {
                $('#photo-preview').html(`<img src="data:image/jpeg;base64,${employee.photo}" alt="Текущее фото">`);
            } else {
                $('#photo-preview').html('<p>Фотография не загружена</p>');
            }

            console.log('Форма предзаполнена для сотрудника:', employee.fullName);
        },
        error: function (xhr, status, error) {
            showMessage('Ошибка при загрузке данных сотрудника: ' + error, 'error');
            console.error('Ошибка загрузки сотрудника:', error);
        }
    });
}

function validateEmployeeForm() {
    let isValid = true;

    const fullName = $('#full-name').val();
    if (!fullName || fullName.length > 100) {
        showError('full-name-error', 'ФИО обязательно и не должно превышать 100 символов');
        isValid = false;
    } else {
        hideError('full-name-error');
    }

    const position = $('#position').val();
    if (!position || position.length > 50) {
        showError('position-error', 'Должность обязательна и не должна превышать 50 символов');
        isValid = false;
    } else {
        hideError('position-error');
    }

    const departmentId = $('#department-id').val();
    if (!departmentId || departmentId <= 0) {
        showError('department-id-error', 'Выберите отдел');
        isValid = false;
    } else {
        hideError('department-id-error');
    }

    return isValid;
}

function validateField(field) {
    const fieldId = field.attr('id');
    const value = field.val();

    switch (fieldId) {
        case 'full-name':
            if (!value || value.length > 100) {
                showError('full-name-error', 'ФИО обязательно и не должно превышать 100 символов');
                field.addClass('error');
            } else {
                hideError('full-name-error');
                field.removeClass('error');
            }
            break;
        case 'position':
            if (!value || value.length > 50) {
                showError('position-error', 'Должность обязательна и не должна превышать 50 символов');
                field.addClass('error');
            } else {
                hideError('position-error');
                field.removeClass('error');
            }
            break;
    }
}

function handlePhotoUpload(e) {
    const file = e.target.files[0];
    if (!file) return;

    if (file.size > 1024 * 1024) {
        showMessage('Файл слишком большой. Максимальный размер: 1MB', 'error');
        $('#photo').val('');
        return;
    }

    const reader = new FileReader();
    reader.onload = function (e) {
        $('#photo-preview').html(`<img src="${e.target.result}" alt="Новое фото">`);
    };
    reader.readAsDataURL(file);
}

function saveEmployee() {
    const formData = new FormData();

    // Добавляем основные данные
    formData.append('DepartmentId', $('#department-id').val());
    formData.append('FullName', $('#full-name').val());
    formData.append('Position', $('#position').val());

    // Добавляем фото если есть, иначе отправляем пустой файл
    const photoFile = $('#photo')[0].files[0];
    if (photoFile) {
        formData.append('Photo', photoFile);
    } else {
        // Если фото нет, отправляем пустой Blob чтобы избежать ошибки валидации
        formData.append('Photo', new Blob());
    }

    const employeeId = $('#employee-id').val();
    const url = employeeId ? `${EMPLOYEES_API_URL}/${employeeId}` : EMPLOYEES_API_URL;
    const method = employeeId ? 'PUT' : 'POST';

    $.ajax({
        url: url,
        type: method,
        data: formData,
        processData: false,
        contentType: false,
        success: function () {
            showMessage(`Сотрудник успешно ${employeeId ? 'обновлен' : 'добавлен'}`, 'success');
            setTimeout(() => {
                window.location.href = 'employees.html';
            }, 1500);
        },
        error: function (xhr, status, error) {
            let errorMessage = 'Ошибка при сохранении: ' + error;
            if (xhr.responseJSON) {
                if (xhr.responseJSON.errors) {
                    errorMessage += '. ' + JSON.stringify(xhr.responseJSON.errors);
                } else if (xhr.responseJSON.title) {
                    errorMessage += '. ' + xhr.responseJSON.title;
                }
            }
            showMessage(errorMessage, 'error');
        }
    });
}

function showError(elementId, message) {
    $('#' + elementId).text(message).addClass('show');
}

function hideError(elementId) {
    $('#' + elementId).removeClass('show');
}

function showMessage(text, type) {
    const messageDiv = $('#message');
    messageDiv.removeClass('message-success message-error')
        .addClass(`message-${type}`)
        .text(text)
        .show();
}