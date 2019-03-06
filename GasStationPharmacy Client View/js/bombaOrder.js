function activate(element, change) {
	if (element.checked) {
		document.getElementById(change).removeAttribute("disabled");
	}
	else{
		document.getElementById(change).setAttribute("disabled","true");
	}
}

function updateRecipe(){
	if(document.getElementById("update").checked){
		document.getElementById("update_recipe").style.display = "block";
	}
	else{
		document.getElementById("update_recipe").style.display = "none";
	}
}

function eliminateRecipe(){
	if(document.getElementById("eliminate").checked){
		document.getElementById("eliminate_recipe").style.display = "block";
	}
	else{
		document.getElementById("eliminate_recipe").style.display = "none";
	}
}

function check(){
	var medicines = document.getElementsByClassName('medicine');
	var count = 0;
	for(i = 0; i < medicines.length; i++){
		if(medicines[i].checked != true){
			count++;
		}
	}
	if(count < medicines.length){
		return true;
	}
	else{
		alert("You need to choose at least one medication!");
		return false;
	}
}

function checkUpdate(){
	var medicines = document.getElementsByClassName('medicineUpdate');
	var count = 0;
	for(i = 0; i < medicines.length; i++){
		if(medicines[i].checked != true){
			count++;
		}
	}
	if(count < medicines.length){
		return true;
	}
	else{
		alert("You need to choose at least one medication!");
		return false;
	}
}

function putPath(){
	document.getElementById("path").value = document.getElementById("file").value;
}
function putPathU(){
	document.getElementById("pathU").value = document.getElementById("fileU").value;
}

function convert(class1,class2,id1){
	var result = "";
	var medicines = document.getElementsByClassName(class1);
	var count = document.getElementsByClassName(class2);
	for(i = 0; i < medicines.length; i++){
		if(medicines[i].checked == true){
			result += medicines[i].value + "=" + count[i].value+"/";
		}
		else{
			continue;
		}
	}
	print(result,id1);
}

function print(result,id1){
	document.getElementById(id1).setAttribute('value',result);
}