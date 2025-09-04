var dataTable;

$(document).ready(function () {

    LoadDataTable();
});

function LoadDataTable() {
    dataTable = $('#DT_load').DataTable({
        "ajax": {
            "url": "/Admin/Product/GetAll"
        },
        "columns": [
            { "data": "name", "width": "15%" },
            { "data": "description", "width": "25%" },
            { "data": "price", "width": "10%" },
            { "data": "category.name", "width": "15%" }
        ],
    })
}