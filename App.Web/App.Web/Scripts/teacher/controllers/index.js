(function (angular) {
    "use strict";

    angular.module("teacher")
        .controller("teacher.controllers.index", ["$scope", "$modal", "teacher.services.index", controller]);


    function controller($scope, $modal, service) {
        $scope.topics = null;

        $scope.disciplineCallback = function() {
            console.log("discipline callback");
        }
    }
})(angular)