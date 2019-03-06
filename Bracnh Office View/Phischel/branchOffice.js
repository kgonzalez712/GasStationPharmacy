var app = angular.module('myApp',[]);
app.controller('myCtrl',function($scope, $http){
    $scope.ip = '172.20.10.2';
    $http.get('http://' + $scope.ip + '/GasStationPharmacyWS/api/Orders/Phischel').
    then(function(response) {
        $scope.list = response.data;
        $scope.list = $scope.list.sort(function(a, b) {
            if (a.OrderTime > b.OrderTime) {
               return -1;
            } else if (a.OrderTime < b.OrderTime) {
                return 1;
            } else {
                return 0;
             }
          });
          $scope.orders = $scope.list;
    });  
});