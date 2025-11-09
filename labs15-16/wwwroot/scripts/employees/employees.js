var apiBaseUrl = window.location.origin + "/api/";
const EMPLOYEES_API_URL = apiBaseUrl + "employees";

$(document).ready(function () {
    loadEmployees();

    $('#employees-list').on('click', '.btn-delete', function () {
        const employeeId = $(this).data('id');
        deleteEmployee(employeeId);
    });
});

function loadEmployees() {
    $('#loading').show();
    $('#employees-list').empty();

    $.ajax({
        url: EMPLOYEES_API_URL,
        type: 'GET',
        success: function (employees) {
            $('#loading').hide();
            if (employees.length === 0) {
                $('#employees-list').html('<p>Нет данных о сотрудниках</p>');
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
                                <p><strong>Отдел:</strong> ${employee.department ? employee.department.name : 'Не назначен'}</p>
                            </div>
                        </div>
                        <div class="item-actions">
                            <a href="employees-edit.html?id=${employee.id}" class="btn btn-edit">Редактировать</a>
                            <button class="btn btn-delete" data-id="${employee.id}">Удалить</button>
                        </div>
                    </div>
                `;
                $('#employees-list').append(employeeCard);
            });
        },
        error: function (xhr, status, error) {
            $('#loading').hide();
            showMessage('Ошибка при загрузке данных: ' + error, 'error');
        }
    });
}

// ДОБАВЛЯЕМ ФУНКЦИЮ УДАЛЕНИЯ
function deleteEmployee(employeeId) {
    if (!confirm('Вы уверены, что хотите удалить этого сотрудника?')) {
        return;
    }

    $.ajax({
        url: `${EMPLOYEES_API_URL}/${employeeId}`,
        type: 'DELETE',
        success: function () {
            loadEmployees();
        }
    });
}

// ДОБАВЛЯЕМ ФУНКЦИЮ ПОКАЗА СООБЩЕНИЙ
function showMessage(text, type) {
    // Создаем временный элемент для сообщения
    const messageDiv = $('<div class="message"></div>')
        .addClass(`message-${type}`)
        .text(text)
        .prependTo('main');

    setTimeout(() => {
        messageDiv.fadeOut(() => messageDiv.remove());
    }, 5000);
}