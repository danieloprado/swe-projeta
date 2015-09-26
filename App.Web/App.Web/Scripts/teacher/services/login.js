(function (angular) {
    "use strict";

    angular.module("teacher")
        .service("teacher.services.index", ["$http", service]);


    function service($http) {

        this.list = function () {
            return $http.post("/api/topic/list");
        }
    }
})(angular)