'use strict'
app.controller('ExploreController', ['$scope', 'News',
    function ($scope, News) {
        $scope.filter = {};

        $scope.search = function () {
            console.log($scope.filter);
            News.filter.query($scope.filter, function (data) {
                $scope.news = data;
            }, function (response) {
                console.log(response.data);
            });
        }

        $scope.search();

    }
])