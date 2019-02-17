var globalFilters = angular.module('globalFilters', []);

globalFilters.filter("trust", ['$sce', function ($sce) {
    return function (htmlCode) {
        return $sce.trustAsHtml(htmlCode);
    }
}]);