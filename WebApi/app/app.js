var toDoPlanner = angular.module('toDoPlanner', ['ngRoute']);

toDoPlanner.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.when("/", {
        controller: "indexController",
        templateUrl:"/Templates/index.html"
    });

    $routeProvider.when("/newToDo", {
        controller: "newController",
        templateUrl: "/Templates/newtodo.html"
    });
   

    $routeProvider.otherwise({ redirectTo: "/" });
}]);