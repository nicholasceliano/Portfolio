var Menu = {
    DocLoad: function () {
        var menuItem = $('#menu li');
        var subMenuItem = $('#menu li div');

        $(subMenuItem).slideUp(0);

        $(menuItem).mouseenter(function () {
            $(this).stop();
            $(this).children().slideDown(500, 'easeOutBack');
        });

        $(menuItem).mouseleave(function () {
            $(subMenuItem).stop();
            $(subMenuItem).slideUp(200, 'easeInBack');
        });
    }
};
