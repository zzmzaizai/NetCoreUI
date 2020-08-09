(function () {
    var e = document.createEvent('Event');
    e.initEvent('NetCoreUI-ready', true, true);
    window.dispatchEvent(e);
})();
