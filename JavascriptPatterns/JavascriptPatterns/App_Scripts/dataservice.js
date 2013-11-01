/// <reference path="../Scripts/require.js" />

define('dataservice', [], function () {
    var msg = "Hello",
        getMessage = function () {
            return msg;
        };

    return {
        getMessage: getMessage
    };
});