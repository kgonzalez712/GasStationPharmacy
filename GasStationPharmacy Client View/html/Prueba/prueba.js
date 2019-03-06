angular.module('demo', [])
.controller('Hello', function($scope, $http) {
    $scope.medicine = {Medicine_Name:"caca",Medicine_Require_Prescription:"No",Medicine_Quantity:20}
    var parameter = JSON.stringify($scope.medicine)
    $http.post('http://localhost:63786/api/Medicines/PH/NewMed',parameter,{headers:{'Content-Type':'application/x-www-form-urlencoded'}}).
        then(function(response) {
            alert(response.data)
            $http.get('http://localhost:63786/api/Medicines/PH/caca').
                then(function(response) {
                alert("response.data.Medicine_Name")
                $scope.medicine = response.data;
            });
        });
});
