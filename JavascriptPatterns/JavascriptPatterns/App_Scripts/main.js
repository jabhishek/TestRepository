/// <reference path="../Scripts/require.js" />
/// <reference path="../Scripts/jquery-1.9.1.js" />
(function () {
    requirejs.config(
        {
            baseUrl: '../../App_Scripts',
            paths: {
                'jquery': '../Scripts/jquery-1.9.1'
            }
        }
        );

    require(['alerter'], function (alerter) {
        alerter.showMessage();
    })
})();