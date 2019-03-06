var URL = '192.168.43.83'
var SUCURSAL = "Phischel"

var myApp = angular.module('myApp', []);
myApp.controller("appController",function($scope,$http){
	$scope.modifyClient = false;
	$scope.selectClient = true;

	$http.get("http://" + URL + "/GasStationPharmacyWS/api/Clients/" + SUCURSAL).then(function(response){
		$scope.clients = response.data;
	});

	$scope.updateClient = function(){
		$http({
			method: 'PUT',
			url: 'http://' + URL + '/GasStationPharmacyWS/api/Clients/' + SUCURSAL + '/' + $scope.client.ClientId + '/UpdateClient',
			data: $scope.client
		}).then(function successCallback(response){
			alert("User has updated Successfully")
		}, function errorCallback(response){
			alert("Error while updating user");
		});
	};

	$scope.deleteClient = function(client){
		$scope.client = client;
		$http({
			method: 'DELETE',
			url:'http://' + URL + '/GasStationPharmacyWS/api/Clients/' + SUCURSAL + '/' + $scope.client.ClientId + '/DeleteClient',
		}).then(function successCallback(response){
			alert("User has deleted Successfully");
		}, function errorCallback(response){
			alert("Error while deleting user");
		});
    };
    
    $scope.createClient = function(){
		$http({
			method: 'POST',
			url:'http://' + URL + '/GasStationPharmacyWS/api/Clients/' + SUCURSAL + '/NewClient',
			data: $scope.client
		}).then(function successCallback(response){
			alert("User has created Successfully")
		}, function errorCallback(response){
			alert("Error while created User");
		});
		// $http.post('',$scope.user,{headers:{'Content-Type':'application/x-www-form-urlencoded'}}).then(function(response){});
	};
	$scope.modify = function(client){
		$scope.client = client;
		$scope.selectClient = false;
		$scope.modifyClient = true;
	};

	$scope.select = function(){
		$scope.modifyClient = false;
		$scope.selectClient = true;
	};

});