var dtble;
$(document).ready(function () {
    loaddata();
});

function loaddata() {
    dtble = $("#datatable").DataTable({
        "ajax": {
            "url": "/Admin/Order/ApprovedOrders",
            "type": "GET",
            "datatype": "json",
            "dataSrc": "data"
        },
        "columns": [
            { "data": "id" },
            { "data": "name" },
            { "data": "phoneNumber" },
            { "data": "applicationUser.email" },
            { "data": "orderStatus" },
            { "data": "totalPrice" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                        <a href="/Admin/Order/Details?orderid=${data}" class="btn btn-warning">Details</a>
                    `;
                }
            }
        ]
    });
}
