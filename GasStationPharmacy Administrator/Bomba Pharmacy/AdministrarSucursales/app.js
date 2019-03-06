//iniciador de la aplicación y el controlador de angularjs para el branchofficemanagement 
var app = angular.module('myApp',[]);
app.controller('myCtrl',function($scope, $http){
    $scope.modify = false;
    $scope.branchtable = false;
    $scope.deletebranch = false;
    $scope.addbranch = false;
    $scope.search = "";
    $scope.ip = '192.168.43.83';

    //función para activar la pantalla para modificar un sucursal, entradas el sucursal a modificar
    $scope.modifyB = function(branch){
        $scope.branch = branch;
        $scope.search = $scope.branch.BranchOfficeName;
        $scope.modify = true;
        $scope.branchtable = false;
        $scope.deletebranch = false;
        $scope.addbranch = false;
    };


//método que llama a un post de una sucursal
    $scope.addBranchOff = function(){
		$http({
			method: 'POST',
			url:'http://' + $scope.ip + '/GasStationPharmacyWS/api/BranchOffices/BombaTica/NewBranch',
			data: $scope.branch
		}).then(function successCallback(response){
			alert("Branch has created Successfully")
		}, function errorCallback(response){
            alert("Error while created Branch");
		});
	};

    //método que llama a un get de sucursales para ingresar estas a la tabla donde el usuario podrá elegir una a modoficar
    $scope.modifyBranch = function(){  
        $http.get('http://' + $scope.ip + '/GasStationPharmacyWS/api/BranchOffices/BombaTica').
        then(function(response) {
            $scope.branches = response.data;
        });  
        $scope.branchtable = true;
        $scope.modify = false;
        $scope.deletebranch = false;
        $scope.addbranch = false;
    };
    
//método para modificar una sucursal, el cual hace un PUT al rest service.
    $scope.updateBranch = function(){
		$http({
			method: 'PUT',
			url: 'http://' + $scope.ip + '/GasStationPharmacyWS/api/BranchOffices/BombaTica/' + $scope.search + '/UpdateBranch',
			data: $scope.branch
		}).then(function successCallback(response){
			alert("Branch has updated Successfully")
		}, function errorCallback(response){
			alert("Error while updating Branch");
		});
	};
//método para eliminar una sucursal
	$scope.deleteBranchOff = function(branch){
        $scope.branch = branch;
		$http({
			method: 'DELETE',
			url:'http://' + $scope.ip + '/GasStationPharmacyWS/api/BranchOffices/BombaTica/' + $scope.branch.BranchOfficeName + '/DeleteBranch',
		}).then(function successCallback(response){
			alert("Branch has deleted Successfully");
		}, function errorCallback(response){
			alert("Error while deleting Branch");
		});
	};

//método para mostrar la pantalla necesaria para agregar una sucursal.
    $scope.addBranch = function(){
        $scope.branch = {};
        $scope.branchtable = false;
        $scope.modify = false;
        $scope.deletebranch = false;
        $scope.addbranch = true;
    };

//método necesario para desplegar la pantalla donde el usuario puede elegir una sucursal a eliminar, hace un get de sucursales para mostrar
//en la tabla.
    $scope.deleteBranch = function(){
        $http.get('http://' + $scope.ip + '/GasStationPharmacyWS/api/BranchOffices/BombaTica').
        then(function(response) {
            $scope.branches = response.data;
        });  
        $scope.deletebranch = true;
        $scope.addbranch = false;
        $scope.modify = false;
        $scope.branchtable = false;
    };
});
