(function (angular) {
    "use strict";

    angular.module("shared")
        .controller("shared.controllers.login", ["$scope", "$location", "shared.services.login", controller]);


    function controller($scope, $location, service) {

        $scope.submit = function (e) {
            e.preventDefault();

            if (!$scope.form.valid()) {
                return;
            }

            service.login($scope.model).success(function(result) {
                if (!result.success) {
                    return;
                }

                $location.path("/");
            });
        };

    }
})(angular)