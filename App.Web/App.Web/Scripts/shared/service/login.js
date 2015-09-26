(function (angular) {
    "use strict";

    angular.module("shared")
        .service("shared.services.login", ["$http", "toaster", service]);


    function service($http, toaster) {

        this.login = function (model) {
            return $http.post("/api/account/login", model)
                .success(function (result) {
                    if (!result.success) {
                        toaster.pop("error", null, result.message, 0);
                        return;
                    }

                    console.log(result);
                    localStorage.setItem("user", JSON.stringify(result.data));
                });
        }
    }
})(angular)