var apiBaseUrl = window.location.origin + "/api/";
const DEPARTMENTS_API_URL = apiBaseUrl + "departments";

$(document).ready(function () {
    const urlParams = new URLSearchParams(window.location.search);
    const departmentId = urlParams.get('id');

    if (departmentId) {
        $('#form-title').text('Редактирование отдела');
        loadDepartment(departmentId);
    }

    $('#department-form').on('submit', function (e) {
        e.preventDefault();
        if (validateDepartmentForm()) {
            saveDepartment();
        }
    });

    $('#cancel-btn').on('click', function () {
        window.location.href = 'departments.html';
    });

    // Валидация при вводе
    $('#name, #location, #budget').on('input', function () {
        validateField($(this));
    });
});

function loadDepartment(departmentId) {
    $.ajax({
        url: `${DEPARTMENTS_API_URL}/${departmentId}`,
        type: 'GET',
        success: function (department) {
            $('#department-id').val(department.id);
            $('#name').val(department.name);
            $('#location').val(department.location);
            $('#budget').val(department.budget);

            // ИСПРАВЛЕНИЕ: Правильно устанавливаем тип отдела
            // department.departmentTypeString содержит строковое значение (например, "Production")
            const departmentTypeValue = getDepartmentTypeValue(department.departmentTypeString);
            $('#department-type').val(departmentTypeValue);
        },
        error: function (xhr, status, error) {
            showMessage('Ошибка при загрузке данных отдела: ' + error, 'error');
        }
    });
}

// Функция для преобразования строкового значения в числовое
function getDepartmentTypeValue(typeString) {
    const typeMap = {
        'Production': 0,
        'Service': 1,
        'Support': 2,
        'Management': 3,
        'Administrative': 4
    };
    return typeMap[typeString] || '';
}

function validateDepartmentForm() {
    let isValid = true;

    // Валидация названия
    const name = $('#name').val();
    if (!name || name.length > 255) {
        showError('name-error', 'Название обязательно и не должно превышать 255 символов');
        isValid = false;
    } else {
        hideError('name-error');
    }

    // Валидация местоположения
    const location = $('#location').val();
    if (!location || location.length > 200) {
        showError('location-error', 'Местоположение обязательно и не должно превышать 200 символов');
        isValid = false;
    } else {
        hideError('location-error');
    }

    // Валидация бюджета
    const budget = parseInt($('#budget').val());
    if (isNaN(budget) || budget < 0 || budget > 100000000) {
        showError('budget-error', 'Бюджет должен быть от 0 до 100,000,000');
        isValid = false;
    } else {
        hideError('budget-error');
    }

    // Валидация типа отдела
    const departmentType = $('#department-type').val();
    if (!departmentType && departmentType !== 0) {
        showError('department-type-error', 'Выберите тип отдела');
        isValid = false;
    } else {
        hideError('department-type-error');
    }

    return isValid;
}

function validateField(field) {
    const fieldId = field.attr('id');
    const value = field.val();

    switch (fieldId) {
        case 'name':
            if (!value || value.length > 255) {
                showError('name-error', 'Название обязательно и не должно превышать 255 символов');
                field.addClass('error');
            } else {
                hideError('name-error');
                field.removeClass('error');
            }
            break;
        case 'location':
            if (!value || value.length > 200) {
                showError('location-error', 'Местоположение обязательно и не должно превышать 200 символов');
                field.addClass('error');
            } else {
                hideError('location-error');
                field.removeClass('error');
            }
            break;
        case 'budget':
            const budget = parseInt(value);
            if (isNaN(budget) || budget < 0 || budget > 100000000) {
                showError('budget-error', 'Бюджет должен быть от 0 до 100,000,000');
                field.addClass('error');
            } else {
                hideError('budget-error');
                field.removeClass('error');
            }
            break;
    }
}

function saveDepartment() {
    const departmentData = {
        name: $('#name').val(),
        location: $('#location').val(),
        budget: parseInt($('#budget').val()),
        departmentType: parseInt($('#department-type').val())
    };

    const departmentId = $('#department-id').val();
    const url = departmentId ? `${DEPARTMENTS_API_URL}/${departmentId}` : DEPARTMENTS_API_URL;
    const method = departmentId ? 'PUT' : 'POST';

    $.ajax({
        url: url,
        type: method,
        contentType: 'application/json',
        data: JSON.stringify(departmentData),
        success: function () {
            showMessage(`Отдел успешно ${departmentId ? 'обновлен' : 'добавлен'}`, 'success');
            setTimeout(() => {
                window.location.href = 'departments.html';
            }, 1500);
        },
        error: function (xhr, status, error) {
            showMessage('Ошибка при сохранении: ' + error, 'error');
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