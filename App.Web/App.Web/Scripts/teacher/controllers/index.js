(function (angular) {
    "use strict";

    angular.module("teacher")
        .controller("teacher.controllers.index", ["$scope", controller]);


    function controller($scope) {

        $scope.$watch("form", function() {
            console.log($scope.form);

        });
    }
})(angular)