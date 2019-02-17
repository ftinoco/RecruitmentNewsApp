var app = angular.module("newsApp", [
        'ngRoute', 'ngResource',
        'ngAria', 'ngMessages',
        'globalFilters'
]);

app.config(function ($routeProvider) {
    $routeProvider
      .when('/', {
          controller: 'HomeController',
          templateUrl: 'app/views/home.html'
      })
      .when('/explore/', {
          controller: 'ExploreController',
          templateUrl: 'app/views/explore.html'
      })
      .otherwise({
          redirectTo: '/'
      });
});

app.controller('mainCtrl', ['$scope', '$location',
     function ($scope, $location) {
         $scope.active = "home";
     }
])