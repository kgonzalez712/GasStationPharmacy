var app = angular.module('myApp',[]);
app.controller('myCtrl',function($scope){
    $scope.masvendidos = false;
    $scope.nuevosoftware = false;
    $scope.compañia = true;
    $scope.ventasporcompañia = true;

    $scope.masVendidosB = function(){
        $scope.masvendidos = true;
        $scope.nuevosoftware = false;
        $scope.compañia = false;
        $scope.ventasporcompañia = false;        
    };    

    $scope.nuevoSoftwareB = function(){
        $scope.masvendidos = false;
        $scope.nuevosoftware = true;
        $scope.compañia = false;
        $scope.ventasporcompañia = false;        
    };
});
