var apiBaseUrl = window.location.origin + "/api/";
const DEPARTMENTS_API_URL = apiBaseUrl + "departments";

$(document).ready(function () {
    loadDepartments();

    $('#departments-list').on('click', '.btn-delete', function () {
        const departmentId = $(this).data('id');
        deleteDepartment(departmentId);
    });
});

function loadDepartments() {
    $('#loading').show();
    $('#departments-list').empty();

    $.ajax({
        url: DEPARTMENTS_API_URL,
        type: 'GET',
        success: function (departments) {
            $('#loading').hide();
            if (departments.length === 0) {
                $('#departments-list').html('<p>Нет данных об отделах</p>');
                return;
            }

            departments.forEach(department => {
                const departmentTypeText = getDepartmentTypeText(department.departmentTypeString);
                const departmentCard = `
                    <div class="item-card">
                        <div class="item-info">
                            <h3><a href="department-details.html?id=${department.id}" class="department-link">${department.name}</a></h3>
                            <p><strong>Местоположение:</strong> ${department.location}</p>
                            <p><strong>Бюджет:</strong> <span class="budget">${formatBudget(department.budget)}</span></p>
                            <p><strong>Тип:</strong> <span class="department-type">${departmentTypeText}</span></p>
                            <p><strong>Сотрудников:</strong> <span class="employees-count">${department.employeesCount}</span></p>
                        </div>
                        <div class="item-actions">
                            <a href="departments-edit.html?id=${department.id}" class="btn btn-edit">Редактировать</a>
                            <button class="btn btn-delete" data-id="${department.id}">Удалить</button>
                        </div>
                    </div>
                `;
                $('#departments-list').append(departmentCard);
            });
        },
        error: function (xhr, status, error) {
            $('#loading').hide();
            showMessage('Ошибка при загрузке данных: ' + error, 'error');
        }
    });
}

function deleteDepartment(departmentId) {
    if (!confirm('Вы уверены, что хотите удалить этот отдел? Все сотрудники отдела также будут удалены!')) {
        return;
    }

    $.ajax({
        url: `${DEPARTMENTS_API_URL}/${departmentId}`,
        type: 'DELETE',
        success: function () {
            showMessage('Отдел успешно удален', 'success');
            loadDepartments();
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