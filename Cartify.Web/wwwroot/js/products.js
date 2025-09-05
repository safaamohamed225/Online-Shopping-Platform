var dataTable;

$(document).ready(function () {

    LoadDataTable();
});

function LoadDataTable() {
    dataTable = $('#DT_load').DataTable({
        "ajax": {
            "url": "/Admin/Product/GetAll",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "name"},
            { "data": "description"},
            { "data": "price"},
            { "data": "category.name" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                                <div class="text-center">
                                    <a href="/Admin/Product/Edit/${data}" class="btn btn-success btn-sm text-white" style="cursor:pointer;">
                                        <i class="fas fa-edit"></i> Edit
                                    </a>
                                    <a onclick="Delete('/Admin/Product/Delete/${data}')" class="btn btn-danger btn-sm text-white" style="cursor:pointer;">
                                        <i class="fas fa-trash-alt"></i> Delete
                                    </a>
                                </div>
                            `;
                }
            }
        ]
    })
}