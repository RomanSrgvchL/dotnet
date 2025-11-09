var apiBaseUrl = window.location.origin + "/api/";
const DEPARTMENTS_API_URL = apiBaseUrl + "departments";

$(document).ready(function () {
    const urlParams = new URLSearchParams(window.location.search);
    const departmentId = urlParams.get('id');

    if (departmentId) {
        loadDepartment(departmentId);
    } else {
        showMessage('ID отдела не указан', 'error');
    }
});

function loadDepartment(departmentId) {
    $('#loading').show();
    $('#department-info').empty();

    $.ajax({
        url: `${DEPARTMENTS_API_URL}/${departmentId}`,
        type: 'GET',
        success: function (department) {
            $('#loading').hide();
            displayDepartmentInfo(department);
            displayDepartmentEmployees(department.employees);
        },
        error: function (xhr, status, error) {
            $('#loading').hide();
            showMessage('Ошибка при загрузке данных отдела: ' + error, 'error');
        }
    });
}

function displayDepartmentInfo(department) {
    const departmentTypeText = getDepartmentTypeText(department.departmentTypeString);

    const departmentInfo = `
        <div class="department-details">
            <h2>${department.name}</h2>
            <div class="details-grid">
                <div class="detail-item">
                    <strong>Местоположение:</strong>
                    <span>${department.location}</span>
                </div>
                <div class="detail-item">
                    <strong>Бюджет:</strong>
                    <span class="budget">${formatBudget(department.budget)}</span>
                </div>
                <div class="detail-item">
                    <strong>Тип отдела:</strong>
                    <span class="department-type">${departmentTypeText}</span>
                </div>
                <div class="detail-item">
                    <strong>Количество сотрудников:</strong>
                    <span class="employees-count">${department.employees ? department.employees.length : 0}</span>
                </div>
            </div>
            <div class="department-actions">
                <a href="departments-edit.html?id=${department.id}" class="btn btn-edit">Редактировать отдел</a>
                <a href="../employees/employees-edit.html?departmentId=${department.id}" class="btn btn-primary">Добавить сотрудника</a>
            </div>
        </div>
    `;

    $('#department-title').text(department.name);
    $('#department-info').html(departmentInfo);
}

function displayDepartmentEmployees(employees) {
    $('#employees-loading').hide();
    const employeesList = $('#employees-list');
    employeesList.empty();

    if (!employees || employees.length === 0) {
        employeesList.html('<p>В этом отделе пока нет сотрудников</p>');
        return;
    }

    employees.forEach(employee => {
        const photoHtml = employee.photo
            ? `<img src="data:image/jpeg;base64,${employee.photo}" class="employee-photo" alt="Фото">`
            : `<div class="no-photo">Нет фото</div>`;

        const employeeCard = `
            <div class="item-card">
                <div class="employee-item">
                    ${photoHtml}
                    <div class="item-info">
                        <h3>${employee.fullName}</h3>
                        <p><strong>Должность:</strong> ${employee.position}</p>
                        <p><strong>ID:</strong> ${employee.id}</p>
                    </div>
                </div>
                <div class="item-actions">
                    <a href="../employees/employees-edit.html?id=${employee.id}" class="btn btn-edit">Редактировать</a>
                    <button class="btn btn-delete" onclick="deleteEmployee(${employee.id})">Удалить</button>
                </div>
            </div>
        `;
        employeesList.append(employeeCard);
    });
}

function deleteEmployee(employeeId) {
    if (!confirm('Вы уверены, что хотите удалить этого сотрудника?')) {
        return;
    }

    $.ajax({
        url: `${apiBaseUrl}employees/${employeeId}`,
        type: 'DELETE',
        success: function () {
            showMessage('Сотрудник успешно удален', 'success');
            // Перезагружаем страницу чтобы обновить список
            const urlParams = new URLSearchParams(window.location.search);
            const departmentId = urlParams.get('id');
            loadDepartment(departmentId);
        },
        error: function (xhr, status, error) {
            showMessage('Ошибка при удалении: ' + error, 'error');
        }
    });
}

function getDepartmentTypeText(typeString) {
    const types = {
        'Production': 'Производственный',
        'Service': 'Сервисный',
        'Support': 'Поддержка',
        'Management': 'Управленческий',
        'Administrative': 'Административный'
    };
    return types[typeString] || typeString;
}

function formatBudget(budget) {
    return new Intl.NumberFormat('ru-RU').format(budget) + ' ₽';
}

function showMessage(text, type) {
    // Создаем контейнер для сообщений если его нет
    let messageContainer = $('#message-container');
    if (messageContainer.length === 0) {
        messageContainer = $('<div id="message-container"></div>').prependTo('.container');
    }

    const messageDiv = $('<div class="message"></div>')
        .addClass(`message-${type}`)
        .text(text)
        .appendTo(messageContainer);

    setTimeout(() => {
        messageDiv.fadeOut(() => messageDiv.remove());
    }, 5000);
}