//iniciador de la aplicación y el controlador de angularjs para el rolemanagement 
var app = angular.module('myApp',[]);
app.controller('myCtrl',function($scope,$http){
    $scope.modify = false;
    $scope.rolestable = false;
    $scope.deleteroles = false;
    $scope.addroles = false;
    $scope.ip = '192.168.43.83';


    //función para activar la pantalla para modificar un rol, entradas el rol a modificar
    $scope.modifyRole = function(role){
        $scope.role = rol;
        $scope.search = role.RoleName;
        $scope.modify = true;
        $scope.rolestable = false;
        $scope.deleteroles = false;
        $scope.addroles = false;
    };
//método que llama a un get de roles para ingresar estos a la tabla donde el usuario podrá elegir una a modificar
    
    $scope.modifyRoles = function(){
        $http.get('http://' + $scope.ip + '/GasStationPharmacyWS/api/Roles/BombaTica').
        then(function(response) {
            $scope.roles = response.data;
        });  
        $scope.rolestable = true;
        $scope.modify = false;
        $scope.deleteroles = false;
        $scope.addroles = false;
    };
    

//método para mostrar la pantalla necesaria para agregar un rol.
    $scope.addRoles = function(){
        $scope.user = {};
        $scope.rolestable = false;
        $scope.modify = false;
        $scope.deleteroles = false;
        $scope.addroles = true;
    };
//método que llama a un post de un rol
    $scope.addRole = function(){
		$http({
			method: 'POST',
			url:'http://' + $scope.ip + '/GasStationPharmacyWS/api/Roles/BombaTica/NewRole',
			data: $scope.role
		}).then(function successCallback(response){
			alert("Rol has created Successfully")
		}, function errorCallback(response){
            alert("Error while created Rol");
		});
	};

    
    //función para activar la pantalla para modificar un rol, entradas el rol a modificar
    $scope.modifyRole = function(rol){ 
        $scope.role = rol;  
        $scope.rolestable = false;
        $scope.modify = true;
        $scope.deletebranch = false;
        $scope.addbranch = false;
    };

//método para modificar un rol, el cual hace un PUT al rest service.
    $scope.updateRol = function(){
		$http({
			method: 'PUT',
			url: 'http://' + $scope.ip + '/GasStationPharmacyWS/api/Roles/BombaTica/' + $scope.role.RoleName + '/UpdateRole',
			data: $scope.role
		}).then(function successCallback(response){
			alert("Rol has updated Successfully")
		}, function errorCallback(response){
			alert("Error while updating Rol");
		});
	};
//método para eliminar una sucursal, hace un delete al rest service
	$scope.deleteRol = function(rol){
        $scope.rol = rol;
		$http({
			method: 'DELETE',
			url:'http://' + $scope.ip + '/GasStationPharmacyWS/api/Roles/BombaTica/' + $scope.rol.RoleName + '/DeleteRole',
		}).then(function successCallback(response){
			alert("Rol has deleted Successfully");
		}, function errorCallback(response){
			alert("Error while deleting Rol");
		});
	};
//método necesario para desplegar la pantalla donde el usuario puede elegir un rol a eliminar, hace un get de roles para mostrar
//en la tabla.
    $scope.deleteRoles = function(){
        $http.get('http://' + $scope.ip + '/GasStationPharmacyWS/api/Roles/BombaTica').
        then(function(response) {
            $scope.roles = response.data;
        });  
        $scope.deleteroles = true;
        $scope.addroles = false;
        $scope.modify = false;
        $scope.rolestable = false;
    };
});
