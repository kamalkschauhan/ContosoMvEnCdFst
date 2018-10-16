var testApp = angular.module("testModule", []).controller("testController", function($scope, $http) {  
    $http.get('http://localhost:49867/api/Values/GetCurrencies').then(function(response) {  
        $scope.Currencies = response.data;  
    });  
});  