var legDetailMessagesModule = (function () {
    var my = {};

    my.init = function () {
        my.wireEvents();
    };

    my.wireEvents = function () {
        $(document).on('click', '[data-command="openModal"]', my.openModal);
    };

    my.openModal = function () {
        var url = $(this).data('url');

        $.get(url,
            function(data) {
                $('#messageModal').html(data);
            });
    }

    my.init();

    return my;
}());