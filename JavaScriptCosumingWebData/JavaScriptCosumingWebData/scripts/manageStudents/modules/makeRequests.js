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

        function deleteJSON(url) {
            var deferred = Q.defer();

            deferred.resolve(
                $.ajax({
                    url: url,
                    type: 'POST',
                    data: { _method: 'delete' },
                    timeout: 5000,
                    success: function (successData) {
                        if (successData) {
                            deferred.resolve(successData);
                        }
                    },
                    error: function (errorData) {
                        deferred.reject(errorData);
                    }
                })
            );

            return deferred.promise;
        };

        return {
            getJSON: getJSON,
            postJSON: postJSON,
            deleteJSON: deleteJSON
        }
    }());

    return httpRequests;
});