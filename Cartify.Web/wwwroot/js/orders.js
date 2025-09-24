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
function Delete(url) {
    Swal.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    if (data.success) {
                        dataTable.ajax.reload();
                        toastr.success(data.message);
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            });
            Swal.fire({
                title: "Deleted!",
                text: "Your file has been deleted.",
                icon: "success"
            });
        }
    });
}
