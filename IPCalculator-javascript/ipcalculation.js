//VARIABLES
var html_networkIp = document.getElementById("ip_network");
var html_broadcastIp = document.getElementById("ip_broadcast");
var html_firstIp = document.getElementById("ip_firsthost");
var html_lastIp = document.getElementById("ip_lasthost");
var html_hostAmount = document.getElementById("host_amount");

var ipAddress, subnetMask;
var hostAmount;
var networkIP;
var broadcastIP;
var firstIP;
var lastIP;

var calc_view = document.getElementsByClassName("calculation-wrapper");
calc_view[0].style.display = "none";
function Calc(){
	RefreshData();
	hostAmount = CalculateHostAmount();
	networkIP = CalculateNetworkIP();
	broadcastIP = CalculateBroadcastIP();
	firstIP = CalculateHostsIP("first");
	lastIP = CalculateHostsIP("last");
	//insert into HTML
	html_networkIp.innerHTML=networkIP.toString().replace(/,/g,"."); //regular expression to replace all occurrencies of comma
	html_broadcastIp.innerHTML=broadcastIP.toString().replace(/,/g,".");
	html_hostAmount.innerHTML=hostAmount.toString().replace(/,/g,".");
	html_firstIp.innerHTML=firstIP.toString().replace(/,/g,".");
	html_lastIp.innerHTML=lastIP.toString().replace(/,/g,".");
	calc_view[0].style.display = "block";
}
function RefreshData(){
ipAddress =  [document.forms["form_ip"]["ip1"].value, document.forms["form_ip"]["ip2"].value, document.forms["form_ip"]["ip3"].value, document.forms["form_ip"]["ip4"].value];
subnetMask = [document.forms["form_ip"]["mask1"].value, document.forms["form_ip"]["mask2"].value, document.forms["form_ip"]["mask3"].value, document.forms["form_ip"]["mask4"].value]
}
function CalculateHostAmount(){
	return 256-subnetMask[3]-2;
}
function CalculateNetworkIP(){
	var result = new Array(4);
	for(var i=0;i<4;i++)
	{
		result[i] = ToDecimal(BinaryLogicAND(ToBinary(ipAddress[i]),ToBinary(subnetMask[i])));
	}
	return result;
}
function CalculateBroadcastIP(){
	var result = new Array(4);
	for(var i=0;i<4;i++)
	{
		result[i] = ToDecimal(BinaryLogicNOT(ToBinary(subnetMask[i])))+networkIP[i];
	}
	return result;
}
function CalculateHostsIP(which)
{
	if(which=="first") return [networkIP[0], networkIP[1], networkIP[2], networkIP[3]+1];
	if(which=="last") return [broadcastIP[0], broadcastIP[1], broadcastIP[2], broadcastIP[3]-1];
}

//BINARY CALCULATION

function ToBinary(value){
	var arrayValue = 0;
	var array = new Array(8);
	
	if(value>=128)
	{
		array[0] = 1;
		arrayValue+= 128;
	}
	if(value-arrayValue>=64)
	{
		array[1] = 1;
		arrayValue+=64;
	}
	if(value-arrayValue>=32)
	{
		array[2] = 1;
		arrayValue+=32;
	}
	if(value-arrayValue>=16)
	{
		array[3] = 1;
		arrayValue+=16;
	}
	if(value-arrayValue>=8)
	{
		array[4] = 1;
		arrayValue+=8;
	}
	if(value-arrayValue>=4)
	{
		array[5] = 1;
		arrayValue+=4;
	}
	if(value-arrayValue>=2)
	{
		array[6] = 1;
		arrayValue+=2;
	}
	if(value-arrayValue>=1)
	{
		array[7] = 1;
		arrayValue+=64;
	}
	for(var i=0;i<array.length;i++)
	{
		if(array[i]==undefined) array[i]=0;
	}
	return array;
}
function ToDecimal(arrValue)
{
	var value=0;
	for(var i=0;i<arrValue.length;i++)
	{
		if(i==0 && arrValue[i]==1) value+=128;
		if(i==1 && arrValue[i]==1) value+=64;
		if(i==2 && arrValue[i]==1) value+=32;
		if(i==3 && arrValue[i]==1) value+=16;
		if(i==4 && arrValue[i]==1) value+=8;
		if(i==5 && arrValue[i]==1) value+=4;
		if(i==6 && arrValue[i]==1) value+=2;
		if(i==7 && arrValue[i]==1) value+=1;
	}
	return value;
}
function BinaryLogicAND(val1,val2)
{
	var result = new Array(8);
	for(var i=0;i<result.length;i++)
	{
		if(val1[i]==1 && val2[i]==1) result[i]=1;
		else {result[i]=0;}
	}
	return result;
}
function BinaryLogicNOT(val1)
{
	var result = new Array(8);
	for(var i=0;i<result.length;i++)
	{
		if(val1[i]==1) result[i] = 0;
		else{ result[i] = 1 }
	}
	return result;
}