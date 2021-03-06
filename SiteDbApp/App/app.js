﻿(function () {
    'use strict';

    angular.module('app', [
        // Angular modules 
        'ngRoute',
        // Custom modules 

        // 3rd Party Modules
        'restangular',
        'ngTable'
    ]).config(restangularConfig);

    restangularConfig.$inject = ['RestangularProvider'];

    function restangularConfig(RestangularProvider) {
        RestangularProvider.setBaseUrl('/api');
    };
})();