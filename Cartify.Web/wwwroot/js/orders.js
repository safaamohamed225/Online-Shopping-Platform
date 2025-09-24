var dataTable;

$(document).ready(function () {

    LoadDataTable();
});

function LoadDataTable() {
    dataTable = $('#DT_load').DataTable({
        "ajax": {
            "url": "/Admin/Order/GetData",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "id" },
            { "data": "name" },
            { "data": "phoneNumber" },
            { "data": "applicationUser.email" },
            { "data": "orderStatus" },
            { "data": "totalprice" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                                    <a href = "/Admin/Order/Details?orderid=${data}" class="btn btn-primary btn-sm text-white" style="cursor:pointer;">
                                        <i class="fas fa-info-circle"></i> Details
                                        </a>
                            `;
                }
            }
        ]
    })
}

