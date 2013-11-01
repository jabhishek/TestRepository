/// <reference path="../Scripts/require.js" />

define('alerter',
    ['jquery', 'dataservice'],
    function ($, dataservice) {
        var name = 'Abhi',
            showMessage = function () {

                var msg = dataservice.getMessage();
                $('#message').text(msg + ' ' + name);
            };
        return {
            showMessage: showMessage
        };
    });