(function (angular) {
    "use strict";

    angular.module("shared")
        .directive("form", [directive]);


    function directive() {
        return {
            restrict: "E",
            scope: false,
            link: function (scope, elem) {
                scope.form = elem;
            }
        }
    }
})(angular)