var legDetailWrapperModule = (function () {
    var my = {};

    my.init = function () {
        my.wireEvents();
    };

    my.wireEvents = function () {
        $(document).on('click', '[data-command="loadTab"]', my.loadTab);
    };

    my.loadTab = function() {
        var url = $(this).data('url');
        $.get(url,
            function(data) {
                $('#tabContent').html(data);
            });
    }

    my.init();

    return my;
}());