(function (angular) {
    "use strict";

    angular.module("gorilla.app", ["ngRoute", "shared", "teacher"])
        .config(["$routeProvider", "$locationProvider", "$httpProvider", "$provide", config])
        .run(["$rootScope", "$location", use]);


    function config($routeProvider, $locationProvider, $httpProvider, $provide) {
        $provide.factory("httpInterceptor", [function () {
            return {
                request: function (config) {
                    config.headers["X-Requested-With"] = "XMLHttpRequest";
                    return config;
                },
                response: function (response) {
                    if (response.headers("x-template")) {
                        setTimeout(function () {
                            var form = angular.element("form");
                            form.removeData("validator");
                            form.removeData("unobtrusiveValidation");
                            $.validator.unobtrusive.parse("form");
                        }, 0);
                    }

                    return response;
                }
            };
        }]);
        $httpProvider.interceptors.push("httpInterceptor");



        $routeProvider.otherwise({ redirectTo: "/teacher" });
        $locationProvider.html5Mode({
            enabled: true,
            requireBase: false
        });
    }

    function use($rootScope, $location) {
        $rootScope.logout = function() {
            localStorage.removeItem("user");
            $location.path("/login");
        }

        $rootScope.isLogged = function() {
            return localStorage.getItem("user") !== null;
        }

        $rootScope.$on("$locationChangeStart", function (event, next, current) {
            if (localStorage.getItem("user") !== null) {
                return;
            }

            if (next.replace(window.location.origin, "") === "/login") {
                return;
            }

            $location.path("/login");
        });
    }
})(angular)