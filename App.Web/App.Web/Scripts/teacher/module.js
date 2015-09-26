(function (angular) {
    "use strict";

    angular.module("teacher", ["ngRoute", "discipline", "ui.bootstrap"])
        .config(["$routeProvider", function ($routeProvider) {
            $routeProvider
              .when("/teacher", {
                  templateUrl: "home/index",
                  controller: "teacher.controllers.index"
              });
        }]);
})(angular)