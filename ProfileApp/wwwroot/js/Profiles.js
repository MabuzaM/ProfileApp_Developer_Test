let dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#DT_load').dataTable({
        "ajax": {
            "url": "/profiles/getall/",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "firstname", "width": "20%" },
            { "data": "surname", "width": "20%" },
            { "data": "website", "width": "20%" },
            { "data": "email", "width": "20%" },
            { "data": "phone", "width": "20%" },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="text-center">
                    <a href="/Profiles/Profilespage?id=${data}" class='btn btn-primary text-white' style='cursor:pointer;'>
                    View Profile
                    </a>
                        </div`;
                }
            }
        ],
        "language": {
            "emptyTable": "no data found"
        },
        
    });
}

function Delete(url) {
    swal({
        title: "Are you Sure",
        text: "Once deleted, you will not be able to recover",
        icon: "warning",
        dangerMode: true,
        buttons: true

    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: "DELETE",
                url: url,
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            });
        }
    });
}