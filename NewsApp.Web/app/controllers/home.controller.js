'use strict'
app.controller('HomeController', ['$scope', 'News',
    function ($scope, News) {
        $scope.error = null;
        $scope.promise = News.resource.query({
            amountOutstanding: 3
        }, success, error).$promise

        function success(news) {
            if (news.length > 0)
                $scope.news = news;
            else {
                $scope.error = "No hay registros de programas.";
            }
        }

        function error(response) {
            console.log(response);
            /*
            if (response.data == null)
                $scope.error = "Ocurrió un error al intentar obtener los datos.";
            else
                $scope.error = "No se encontraron datos de programas para el filtro especificado.";*/
        }
    }
])