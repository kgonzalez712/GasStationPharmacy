var URL = "172.20.10.2";
var myApp = angular.module('myApp', []);
myApp.controller("appController",function($scope,$http){
	$http.get("http://" + URL + "/GasStationPharmacyWS/api/Clients/BombaTica/123456789").then(function(response){
		$scope.user = response.data;
	});

	$scope.updateUser = function(){
		$http({
			method: 'PUT',
			url: 'http://' + URL + '/GasStationPharmacyWS/api/Clients/BombaTica/' + $scope.user.ClientId + '/UpdateClient',
			data: $scope.user
		}).then(function successCallback(response){
			alert("User has updated Successfully")
		}, function errorCallback(response){
			alert("Error while updating user");
		});
	};

	$scope.deleteUser = function(){
		$http({
			method: 'DELETE',
			url:'http://' + URL + '/GasStationPharmacyWS/api/Clients/BombaTica/' + $scope.user.ClientId + '/DeleteClient',
		}).then(function successCallback(response){
			alert("User has deleted Successfully");
		}, function errorCallback(response){
			alert("Error while deleting user");
		});
	};

});