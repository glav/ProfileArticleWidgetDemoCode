jQuery(document).ready(function () {
    $("#buy-now").on('click', function () {
        var select = $("#widget-select").val();
        window.location.href = "/purchase?id=" + select;
    });

    $("#confirm").on('click', function () {
        alert('Congrats! You have purchased your widget and it will be sent to you because we know where you live!');
        window.location.href = "/";
    });
});
