angular.module("newsApp")
.factory('News', ['$resource', function ($resource) { 
    return { 
		resource: $resource("http://localhost/newsapp/services/api/news/:amountOutstanding", {
			amountOutstanding: '@amountOutstanding'
		}),
		filter: $resource("http://localhost/newsapp/services/api/news/list", {}, {
			query: {
				method: 'POST', 
				isArray: true
			}
		})
	};
}
]);