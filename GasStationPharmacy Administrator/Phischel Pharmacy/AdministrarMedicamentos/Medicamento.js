var URL = '192.168.43.83'
var SUCURSAL = "Phischel"
var myApp = angular.module('myApp', []);

myApp.controller("appController",function($scope,$http){
	$scope.modifyMedicine = false;
	$scope.selectMedicine = true;


	$http.get('http://' + URL + '/GasStationPharmacyWS/api/Medicines/' + SUCURSAL).
	then(function(response){
		$scope.medicines = response.data;
	});

	$scope.updateMedicine = function(){
		$http({
			method: 'PUT',
			url: 'http://' + URL + '/GasStationPharmacyWS/api/Medicines/' + SUCURSAL + '/' + $scope.medicine.MedicineName + '/UpdateMedicine',
			data: $scope.medicine
		}).then(function successCallback(response){
			alert("User has updated Successfully")
		}, function errorCallback(response){
			alert("Error while updating user");
		});
	};

	$scope.deleteMedicine = function(medicine){
		$scope.medicine = medicine;
		$http({
			method: 'DELETE',
			url:'http://' + URL + '/GasStationPharmacyWS/api/Medicines/' + SUCURSAL + '/' + $scope.medicine.MedicineName + '/DeleteMedicine',
		}).then(function successCallback(response){
			alert("User has deleted Successfully");
		}, function errorCallback(response){
			alert("Error while deleting user");
		});
    };
    
    $scope.createMedicine = function(){
		$http({
			method: 'POST',
			url:'http://' + URL + '/GasStationPharmacyWS/api/Medicines/' + SUCURSAL + '/NewMed',
			data: $scope.medicine
		}).then(function successCallback(response){
			alert("User has created Successfully")
		}, function errorCallback(response){
			alert("Error while created User");
		});
		// $http.post('',$scope.user,{headers:{'Content-Type':'application/x-www-form-urlencoded'}}).then(function(response){});
	};

	$scope.modify = function(medicine){
		$scope.medicine = medicine;
		$scope.selectMedicine = false;
		$scope.modifyMedicine = true;
	};

	$scope.select = function(){
		$scope.modifyMedicine = false;
		$scope.selectMedicine = true;
	};

});