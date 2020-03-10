
//sends an alert when the button is clicked.
$(document).ready(function () {
    $("button").click(function () {
        $.ajax({
            url: "/Home/test",
            
            success: function (data) {
                //replace content of the div with a new partial view.
                $('#partialView').html(data);
            },
            error: function (xhr) {
                alert("An error occured: " + xhr.status + " " + xhr.statusText);
            }
        });
    });
});