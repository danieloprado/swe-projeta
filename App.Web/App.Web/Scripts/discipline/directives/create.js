(function (angular) {
    "use strict";

    angular.module("discipline")
        .directive("disciplineCreate", ["$modal",directive]);


    function directive($modal) {
        return {
            restrict: "EAC",
            scope: {
                callback: "&"
            },
            link: function (scope, elem) {
                elem.click(function() {
                    $modal.open({
                        templateUrl: "/discipline/create",
                        controller: "discipline.controllers.create"
                    }).result.then(function (data) {
                        scope.callback({ $value: data });
                    });
                });
            }
        }
    }
})(angular)