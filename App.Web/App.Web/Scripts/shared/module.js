(function (angular) {
    "use strict";

    angular.module("shared", ["toaster"])
    .config(["$routeProvider", function ($routeProvider) {
        $routeProvider
          .when("/login", {
              templateUrl: "shared/home",
              controller: "shared.controllers.home"
          })
          .when("/login", {
              templateUrl: "shared/login",
              controller: "shared.controllers.login"
          });
    }]);
})(angular)