'use strict'
app.controller('ExploreController', ['$scope', 'News',
    function ($scope, News) {
        $scope.filter = {};

        $scope.buscar = function () {
            News.filter.query($scope.filter, function (data) {
                $scope.news = data;
            }, function (response) {
                console.log(response.data);
            });
        }

        $scope.buscar();

    }
])