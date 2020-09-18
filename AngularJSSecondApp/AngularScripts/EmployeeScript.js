var app = angular
    .module("secondModule",[])
    .controller("secondController", function ($scope, $http) {
        debugger;
        $http.get('/Employee/GetEmployeesData')

            .then(function (response) {
                debugger;
                console.log(response.data);
                $scope.employees = response.data;
            });
    });