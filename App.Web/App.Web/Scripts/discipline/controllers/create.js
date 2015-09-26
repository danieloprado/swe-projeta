(function (angular) {
    "use strict";

    angular.module("discipline")
        .controller("discipline.controllers.create", ["$scope", "discipline.services.shared", controller]);


    function controller($scope, service) {
        $scope.submit = function (e) {
            e.preventDefault();

            if (!$scope.form.valid()) {
                return;
            }

            service.create($scope.model)
                .success(function(result) {
                    if (!result.success) {
                        return;
                    }
                    
                    $scope.$close(result.data);
                });
        };
    }
})(angular)