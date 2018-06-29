//LANGUAGE MODULE
if(navigator.language!="pl")
{
	document.title = "IP Calculator";
	document.getElementsByClassName("btn_calc")[0].innerHTML = "Calculate";
	document.getElementsByClassName("text_address")[0].innerHTML = "IP Address";
	document.getElementsByClassName("text_address")[1].innerHTML = "Subnet Mask";
	document.getElementsByClassName("text_address")[2].innerHTML = "Network IP";
	document.getElementsByClassName("text_address")[3].innerHTML = "Broadcast IP";
	document.getElementsByClassName("text_address")[4].innerHTML = "Number of hosts";
	document.getElementsByClassName("text_address")[5].innerHTML = "First Host IP";
	document.getElementsByClassName("text_address")[6].innerHTML = "Last Host IP";
}