(function () {
    'use strict';

    angular
        .module('app')
        .controller('SitesController', SitesController);

    SitesController.$inject = ['Restangular'];

    function SitesController(Restangular) {
        /* jshint validthis:true */
        var vm = this;
        vm.sites = [];

        activate();

        function activate() {
            Restangular.all('sitesapi').getList().then(function (sites) {
                vm.sites = sites;
            });
        }
    }
})();