(function (angular) {
    "use strict";

    angular.module("discipline")
        .service("discipline.services.shared", ["$http", "toaster", service]);


    function service($http, toaster) {

        this.create = function (model) {
            return $http.post("/api/discipline/create", model)
                .success(function (result) {
                    if (result.success) {
                        return;
                    }

                    toaster.pop("error", null, result.message, 0);
                });
        }
    }
})(angular)