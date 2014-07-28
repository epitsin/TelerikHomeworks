(function () {
    'use strict';

    require.config({
        paths: {
            jquery: '../libs/jquery-2.1.1.min',
            httpRequests: 'httpRequests',
            q: '../libs/q'
        }
    });

    require(['jquery', 'httpRequests'],
        function ($, httpRequests) {
            httpRequests.getJSON('scripts/performHttpRequests/data.txt')
            .then(function (data) {
                console.log(data);
            }, function () {
                console.log('Error');
            })
        });
}());