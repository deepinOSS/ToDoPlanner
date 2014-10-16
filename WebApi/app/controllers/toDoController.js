toDoPlanner.controller('indexController', ['$scope', 'toDoService', function ($scope, toDoService) {
    //$scope.data = [{ "createdBy": { "id": "9871e50f-5240-46eb-9508-4d290d8244bb", "firstName": "MathiRajan", "lastName": "Kathirvel Rajan" }, "id": "2f33a594-a5fe-4205-acde-2d61c4ded6fe", "title": "Create a Mobile app", "description": "for integrating with mobile concepts", "createdOn": "2014-10-12T00:00:00" }, { "createdBy": { "id": "daf15a38-fb69-4c11-9670-cde63b5806a8", "firstName": "Shankar", "lastName": "Ram" }, "id": "7771046b-5534-4959-84a2-606e741c822c", "title": "Read ASP.NET MVC", "description": "Preparing for the ToDo planner", "createdOn": "2014-07-01T00:00:00" }, { "createdBy": { "id": "9871e50f-5240-46eb-9508-4d290d8244bb", "firstName": "MathiRajan", "lastName": "Kathirvel Rajan" }, "id": "101fdedc-8466-43c8-b778-ceefd4fc8418", "title": "Create ToDo application", "description": "for learning ASP.NET MVC and apply the concepts", "createdOn": "2014-08-31T00:00:00" }, { "createdBy": { "id": "404e6509-9c7e-4fa6-a81a-cd14bc69265a", "firstName": "Pradeep", "lastName": "Gunasekaran" }, "id": "cd1f42a6-d8b3-4a08-adb4-f0f657440cd8", "title": "implement oAuth", "description": "for learning security concepts in ASP.NET MVC and apply the concepts", "createdOn": "2013-10-02T00:00:00" }];
    $scope.data = toDoService;

    //handlers
    $scope.deleteToDo = function (toDoId) {
        console.log(toDoId);
        toDoService.deleteToDo(toDoId)
            .then(function () {
                //success
                console.log('deleted id:' + toDoId);

                toDoService.getAllToDos().then(function () {
                    //success
                },
                function () {
                    //error
                });

            },
            function () {
                //error
            });
    };

    //Get ToDos
    toDoService.getAllToDos().then(function () {
        //success
    },
    function () {
        //error
    });

    

}]);

toDoPlanner.controller('newController', ['$scope', '$window', 'toDoService', function ($scope, $window, toDoService) {
    //$scope.data = [{ "createdBy": { "id": "9871e50f-5240-46eb-9508-4d290d8244bb", "firstName": "MathiRajan", "lastName": "Kathirvel Rajan" }, "id": "2f33a594-a5fe-4205-acde-2d61c4ded6fe", "title": "Create a Mobile app", "description": "for integrating with mobile concepts", "createdOn": "2014-10-12T00:00:00" }, { "createdBy": { "id": "daf15a38-fb69-4c11-9670-cde63b5806a8", "firstName": "Shankar", "lastName": "Ram" }, "id": "7771046b-5534-4959-84a2-606e741c822c", "title": "Read ASP.NET MVC", "description": "Preparing for the ToDo planner", "createdOn": "2014-07-01T00:00:00" }, { "createdBy": { "id": "9871e50f-5240-46eb-9508-4d290d8244bb", "firstName": "MathiRajan", "lastName": "Kathirvel Rajan" }, "id": "101fdedc-8466-43c8-b778-ceefd4fc8418", "title": "Create ToDo application", "description": "for learning ASP.NET MVC and apply the concepts", "createdOn": "2014-08-31T00:00:00" }, { "createdBy": { "id": "404e6509-9c7e-4fa6-a81a-cd14bc69265a", "firstName": "Pradeep", "lastName": "Gunasekaran" }, "id": "cd1f42a6-d8b3-4a08-adb4-f0f657440cd8", "title": "implement oAuth", "description": "for learning security concepts in ASP.NET MVC and apply the concepts", "createdOn": "2013-10-02T00:00:00" }];
    //$scope.data = toDoService;
    //toDoService.getAllToDos().then(function () {
    //    //success
    //},
    //function () {
    //    //error
    //});
    $scope.newToDo = {};
    $scope.fndlname;

    //handlers
    $scope.createToDo = function () {
        var namearr = $scope.fndlname.split(',');
        var _fname = namearr[1];
        var _lname = namearr[0];
        var _newToDo;
        _newToDo = $scope.newToDo;
        _newToDo.createdBy = {};
        _newToDo.createdBy.firstName = _fname;
        _newToDo.createdBy.lastName = _lname;

        toDoService.createToDo(_newToDo)
            .then(function () {
                //success

                //redirect to index page
                $window.location.href = '/';
            },
            function () {
                //error

            });
    };

}]);


toDoPlanner.controller('deleteController', ['$scope', '$routeParams', 'toDoService', function ($scope, $routeParams, toDoService) {
    //$scope.data = [{ "createdBy": { "id": "9871e50f-5240-46eb-9508-4d290d8244bb", "firstName": "MathiRajan", "lastName": "Kathirvel Rajan" }, "id": "2f33a594-a5fe-4205-acde-2d61c4ded6fe", "title": "Create a Mobile app", "description": "for integrating with mobile concepts", "createdOn": "2014-10-12T00:00:00" }, { "createdBy": { "id": "daf15a38-fb69-4c11-9670-cde63b5806a8", "firstName": "Shankar", "lastName": "Ram" }, "id": "7771046b-5534-4959-84a2-606e741c822c", "title": "Read ASP.NET MVC", "description": "Preparing for the ToDo planner", "createdOn": "2014-07-01T00:00:00" }, { "createdBy": { "id": "9871e50f-5240-46eb-9508-4d290d8244bb", "firstName": "MathiRajan", "lastName": "Kathirvel Rajan" }, "id": "101fdedc-8466-43c8-b778-ceefd4fc8418", "title": "Create ToDo application", "description": "for learning ASP.NET MVC and apply the concepts", "createdOn": "2014-08-31T00:00:00" }, { "createdBy": { "id": "404e6509-9c7e-4fa6-a81a-cd14bc69265a", "firstName": "Pradeep", "lastName": "Gunasekaran" }, "id": "cd1f42a6-d8b3-4a08-adb4-f0f657440cd8", "title": "implement oAuth", "description": "for learning security concepts in ASP.NET MVC and apply the concepts", "createdOn": "2013-10-02T00:00:00" }];
    //$scope.data = toDoService;
    //toDoService.getAllToDos().then(function () {
    //    //success
    //},
    //function () {
    //    //error
    //});
    //var _todoid = $routeParams.toDoId;
    //toDoService.deleteToDo(_todoid)
    //    .then(function () {
    //        //success
    //        console.log('deleted id:' + _todoid);
    //    },
    //    function () {
    //        //error
    //    });    

}]);