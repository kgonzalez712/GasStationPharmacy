var URL = '192.168.43.83'
var SUCURSAL = 'Phischel'

var myApp = angular.module('myApp', []);
myApp.controller("appController",function($scope,$http){
	$scope.modifyDcotor = false;
	$scope.selectDoctor = true;


	$http.get('http://' + URL + '/GasStationPharmacyWS/api/Doctors/' + SUCURSAL).then(function(response){
		$scope.doctors = response.data;
	});

	$scope.updateDoctor = function(){
		$http({
			method: 'PUT',
			url: 'http://' + URL + '/GasStationPharmacyWS/api/Doctors/' + SUCURSAL + '/' + $scope.doctor.DoctorDid + '/UpdateDoc',
			data: $scope.doctor
		}).then(function successCallback(response){ 
			alert("User has updated Successfully")
		}, function errorCallback(response){
			alert("Error while updating user");
		});
	};

	$scope.deleteDoctor = function(doctor){
		$scope.doctor = doctor;
		$http({
			method: 'DELETE',
			url:'http://' + URL + '/GasStationPharmacyWS/api/Doctors/' + SUCURSAL + '/' + $scope.doctor.DoctorDid + '/DeleteDoctor',
		}).then(function successCallback(response){
			alert("User has deleted Successfully");
		}, function errorCallback(response){
			alert("Error while deleting user");
		});
    };
    
    $scope.createDoctor = function(){
		$http({
			method: 'POST',
			url:'http://' + URL + '/GasStationPharmacyWS/api/Doctors/' + SUCURSAL + '/NewDoctor' ,
			data: $scope.doctor
		}).then(function successCallback(response){
			alert("User has created Successfully")
		}, function errorCallback(response){
			alert("Error while created User");
		});
		// $http.post('',$scope.user,{headers:{'Content-Type':'application/x-www-form-urlencoded'}}).then(function(response){});
	};

	$scope.modify = function(doctor){
		$scope.doctor = doctor;
		$scope.selectDoctor = false;
		$scope.modifyClient = true;
	};

	$scope.select = function(){
		$scope.modifyDoctor = false;
		$scope.selectDoctor = true;
	};

});