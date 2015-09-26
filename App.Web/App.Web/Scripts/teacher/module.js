(function (angular) {
    "use strict";

    angular.module("teacher", ["ngRoute"])
        .config(["$routeProvider", function ($routeProvider) {
            $routeProvider
              .when("/teacher", {
                  templateUrl: "home/index",
                  controller: "teacher.controllers.index"
              });
        }]);
})(angular)