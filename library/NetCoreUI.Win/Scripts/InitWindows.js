window._NetCoreUI = new NetCoreUIBridge(function (e) { window.external.notify(e); });
window._NetCoreUI.updateTitle(document.title);

if (typeof MutationObserver !== 'undefined') {
    new MutationObserver(function () {
        window._NetCoreUI.updateTitle(document.title);
    }).observe(document.querySelector('title'),
        { subtree: true, characterData: true, childList: true });
} else if (document.attachEvent) {
    document.attachEvent('onpropertychange', function (e) {
        if (e.propertyName === 'title') {
            window._NetCoreUI.updateTitle(document.title);
        }
    });
}
