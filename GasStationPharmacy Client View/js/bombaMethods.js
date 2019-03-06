var URL = "172.20.10.2";
var myApp = angular.module('myApp', []);
myApp.controller("appController",function($scope,$http){
	
	$scope.createRecipe = function(){
		$http({
			method: 'POST',
			url: 'http://' + URL + '/GasStationPharmacyWS/api/Recipes/BombaTica/NewRecipe',
			data: $scope.recipeCreate
		}).then(function successCallback(response){
			alert("Recipe has created Successfully")
		}, function errorCallback(response){
			alert("Error while created Recipe");
		});
	};

	$scope.updateRecipe = function(){
		$http({
			method: 'PUT',
			url: 'http://' + URL + '/GasStationPharmacyWS/api/Recipes/BombaTica/' + $scope.recipeUpdate.RecipeNumber + '/UpdateRecipe',
			data: $scope.recipeUpdate
		}).then(function successCallback(response){
			alert("Recipe has updated Successfully")
		}, function errorCallback(response){
			alert("Error while updating recipe");
		});
	};

	$scope.deleteRecipe = function(){
		$http({
			method: 'DELETE',
			url:'http://' + URL + '/GasStationPharmacyWS/api/Recipes/BombaTica/' + $scope.recipeDelete.RecipeNumber + '/DeleteRecipe'
		}).then(function successCallback(response){
			alert("Recipe has deleted Successfully");
		}, function errorCallback(response){
			alert("Error while deleting recipe");
		});
	};

	$scope.createUser = function(){
		$http({
			method: 'POST',
			url:'http://' + URL + '/GasStationPharmacyWS/api/Clients/BombaTica/NewClient',
			data: $scope.user
		}).then(function successCallback(response){
			alert("User has created Successfully")
		}, function errorCallback(response){
			alert("Error while created User");
		});
		// $http.post('',$scope.user,{headers:{'Content-Type':'application/x-www-form-urlencoded'}}).then(function(response){});
	};

	$scope.createOrder = function(){
		$http({
			method: 'POST',
			url: 'http://' + URL + '/GasStationPharmacyWS/api/Orders/BombaTica/NewOrder',
			data: $scope.orderCreate
		}).then(function successCallback(response){
			alert("Order has created Successfully");
		}, function errorCallback(response){
			alert("Error while created Order");
		});
	};

	$scope.deleteOrder = function(){
		$http({
			method: 'DELETE',
			url:'http://' + URL + '/GasStationPharmacyWS/api/Orders/BombaTica/' + $scope.orderDelete.OrderId + '/DeleteOrder'
		}).then(function successCallback(response){
			alert("Order has deleted Successfully");
		}, function errorCallback(response){
			alert("Error while deleting order");
		});
	};

	$scope.updateOrder = function(){
		$http({
			method: 'PUT',
			url: 'http://' + URL + '/GasStationPharmacyWS/api/Orders/BombaTica/' + $scope.orderUpdate.OrderId + '/UpdateOrder',
			data: $scope.orderUpdate
		}).then(function successCallback(response){
			alert("Recipe has updated Successfully")
		}, function errorCallback(response){
			alert("Error while updating recipe");
		});
	};
});