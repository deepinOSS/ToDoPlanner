toDoPlanner.factory('toDoService',['$http','$q', function ($http, $q) {
    var _toDos = [];

    //Retreive All
    _getAllToDos = function(){
        var deferred = $q.defer();

        $http.get('/api/todoplanner')
            .then(function (result) {
                //success
                _toDos = angular.copy(result.data, _toDos);
                deferred.resolve();
            },
            function () {
                //error
                console.log('Error in retreiving todos from /api/todoplanner');
                deferred.reject();
            });

        return deferred.promise;
    };

    //Delete
    _deleteToDo = function (id) {
        var deferred = $q.defer();

        $http.delete('/api/todoplanner/' + id)
        .then(function (response) {
            //success
            
            deferred.resolve();
        },
        function () {
            //error
            console.log('Error in deleting todos using /api/todoplanner/' + id);
            deferred.reject();
        })
        ;

        return deferred.promise;
    };

    //Create
    _createToDo = function (newToDo) {

        var deferred = $q.defer();

        $http.post('/api/todoplanner', newToDo)
            .then(function (result) {
                //success
                
                deferred.resolve();
            },
            function () {
                //error
                console.log('Error in creating todo using /api/todoplanner');
                deferred.reject();
            });

        return deferred.promise;
    };

    return {
        toDos: _toDos,
        getAllToDos: _getAllToDos,
        deleteToDo: _deleteToDo,
        createToDo:_createToDo
    };
}]);