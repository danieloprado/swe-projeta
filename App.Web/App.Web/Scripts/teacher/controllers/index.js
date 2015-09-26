(function (angular) {
    "use strict";

    angular.module("teacher")
        .controller("teacher.controllers.index", ["$scope", "$modal", "discipline.services.shared", controller]);


    function controller($scope, $modal, service) {
        $scope.disciplines = null;

        $scope.disciplineCallback = function(discipline) {
            $scope.disciplines.push(discipline);
        }

        service.list().success(function(data) {
            $scope.disciplines = data;
        });
    }
})(angular)