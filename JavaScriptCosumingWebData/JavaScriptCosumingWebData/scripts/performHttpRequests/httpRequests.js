//Create a module that exposes methods for performing HTTP requests by given URL and headers
//  getJSON and postJSON
//  Both methods should work with promises

define(['jquery', 'q'], function ($, Q) {
    'use strict';

    var httpRequests;
    httpRequests = (function () {
        function makeHttpRequest(url, type, data) {
            var defered = Q.defer();

            var stringifiedData = '';
            if (data) {
                stringifiedData = JSON.stringify(data);
            }

            $.ajax({
                url: url,
                type: type,
                data: stringifiedData,
                contentType: 'application/json',
                timeout: 5000,
                success: function (successData) {
                    defered.resolve(successData);
                },
                error: function (errorData) {
                    defered.reject(errorData);
                }
            });

            return defered.promise;
        };

        function getJSON(url) {
            return makeHttpRequest(url, 'GET');
        };

        function postJSON(url, data) {
            return makeHttpRequest(url, 'POST', data);
        };

        return {
            getJSON: getJSON,
            postJSON: postJSON
        }
    }());

    return httpRequests;
});