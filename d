[1mdiff --git a/IPCalculator-javascript/index.html b/IPCalculator-javascript/index.html[m
[1mnew file mode 100644[m
[1mindex 0000000..bb442da[m
[1m--- /dev/null[m
[1m+++ b/IPCalculator-javascript/index.html[m
[36m@@ -0,0 +1,68 @@[m
[32m+[m[32m<!DOCTYPE html>[m
[32m+[m[32m<html lang="en">[m
[32m+[m[32m    <head>[m
[32m+[m		[32m<meta charset="utf-8">[m
[32m+[m[32m        <title>Kalkulator IP</title>[m
[32m+[m[32m        <link rel=stylesheet href="./style.css">[m
[32m+[m[32m    </head>[m
[32m+[m[32m    <body>[m
[32m+[m		[32m<header>[m
[32m+[m			[32m<h1>Kalkulator IP</h1>[m
[32m+[m			[32m<button class="f-right btn_calc" onclick="Calc()">Działaj</button>[m
[32m+[m		[32m</header>[m
[32m+[m[32m        <div class="form-wrapper">[m
[32m+[m[32m            <form name="form_ip">[m
[32m+[m[32m                <div id="input_ipAddress" class="address-wrapper">[m
[32m+[m					[32m<span class="text_address">Adres IP</span>[m
[32m+[m					[32m<div class="f-right">[m
[32m+[m						[32m<input name="ip1" class="ip-input" type="number" min="0" max="255" maxlength="3"></input>[m
[32m+[m						[32m<span>.</span>[m
[32m+[m						[32m<input name="ip2" class="ip-input" type="number" min="0" max="255" maxlength="3"></input>[m
[32m+[m						[32m<span>.</span>[m
[32m+[m						[32m<input name="ip3" class="ip-input" type="number" min="0" max="255" maxlength="3"></input>[m
[32m+[m						[32m<span>.</span>[m
[32m+[m						[32m<input name="ip4" class="ip-input" type="number" min="0" max="255" maxlength="3"></input>[m
[32m+[m					[32m</div>[m
[32m+[m					[32m<div class="f-clear"></div>[m
[32m+[m[32m                </div>[m
[32m+[m[32m                <div id="input_subnetMask" class="address-wrapper">[m
[32m+[m[32m                    <span class="text_address">Maska podsieci</span>[m
[32m+[m					[32m<div class="f-right">[m
[32m+[m						[32m<input name="mask1" class="ip-input" type="number" min="0" max="255" maxlength="3"></input>[m
[32m+[m						[32m<span>.</span>[m
[32m+[m						[32m<input name="mask2" class="ip-input" type="number" min="0" max="255" maxlength="3"></input>[m
[32m+[m						[32m<span>.</span>[m
[32m+[m						[32m<input name="mask3"class="ip-input" type="number" min="0" max="255" maxlength="3"></input>[m
[32m+[m						[32m<span>.</span>[m
[32m+[m						[32m<input name="mask4"class="ip-input" type="number" min="0" max="255" maxlength="3"></input>[m
[32m+[m					[32m</div>[m
[32m+[m					[32m<div class="f-clear"></div>[m
[32m+[m[32m                </div>[m
[32m+[m[32m            </form>[m
[32m+[m[32m        </div>[m
[32m+[m[32m        <div class="calculation-wrapper">[m
[32m+[m[32m            <div class="address-wrapper">[m
[32m+[m[32m                <p class="text_address f-left">Adres sieci</p>[m
[32m+[m[32m                <p class="f-right" id="ip_network"></p>[m
[32m+[m[32m            </div>[m
[32m+[m[32m            <div class="address-wrapper">[m
[32m+[m[32m                <p class="text_address f-left">Adres rozgłoszeniowy</p>[m
[32m+[m[32m                <p class="f-right" id="ip_broadcast"></p>[m
[32m+[m[32m            </div>[m
[32m+[m			[32m<div class="address-wrapper">[m
[32m+[m[32m                <p class="text_address f-left">Liczba hostów</p>[m
[32m+[m[32m                <p class="f-right" id="host_amount"></p>[m
[32m+[m[32m            </div>[m
[32m+[m[32m            <div class="address-wrapper">[m
[32m+[m[32m                <p class="text_address f-left">Adres pierwszego klienta</p>[m
[32m+[m[32m                <p class="f-right" id="ip_firsthost"></p>[m
[32m+[m[32m            </div>[m
[32m+[m[32m            <div class="address-wrapper">[m
[32m+[m[32m                <p class="text_address f-left">Adres ostatniego klienta</p>[m
[32m+[m[32m                <p class="f-right" id="ip_lasthost"></p>[m
[32m+[m[32m            </div>[m
[32m+[m[32m        </div>[m
[32m+[m[32m    </body>[m
[32m+[m	[32m<script src="ipcalculation.js"></script>[m
[32m+[m	[32m<script src="languagemodule.js"></script>[m
[32m+[m[32m<html>[m
\ No newline at end of file[m
[1mdiff --git a/IPCalculator-javascript/ipcalculation.js b/IPCalculator-javascript/ipcalculation.js[m
[1mnew file mode 100644[m
[1mindex 0000000..a6ecb04[m
[1m--- /dev/null[m
[1m+++ b/IPCalculator-javascript/ipcalculation.js[m
[36m@@ -0,0 +1,148 @@[m
[32m+[m[32m//VARIABLES[m
[32m+[m[32mvar html_networkIp = document.getElementById("ip_network");[m
[32m+[m[32mvar html_broadcastIp = document.getElementById("ip_broadcast");[m
[32m+[m[32mvar html_firstIp = document.getElementById("ip_firsthost");[m
[32m+[m[32mvar html_lastIp = document.getElementById("ip_lasthost");[m
[32m+[m[32mvar html_hostAmount = document.getElementById("host_amount");[m
[32m+[m
[32m+[m[32mvar ipAddress, subnetMask;[m
[32m+[m[32mvar hostAmount;[m
[32m+[m[32mvar networkIP;[m
[32m+[m[32mvar broadcastIP;[m
[32m+[m[32mvar firstIP;[m
[32m+[m[32mvar lastIP;[m
[32m+[m
[32m+[m[32mvar calc_view = document.getElementsByClassName("calculation-wrapper");[m
[32m+[m[32mcalc_view[0].style.display = "none";[m
[32m+[m[32mfunction Calc(){[m
[32m+[m	[32mRefreshData();[m
[32m+[m	[32mhostAmount = CalculateHostAmount();[m
[32m+[m	[32mnetworkIP = CalculateNetworkIP();[m
[32m+[m	[32mbroadcastIP = CalculateBroadcastIP();[m
[32m+[m	[32mfirstIP = CalculateHostsIP("first");[m
[32m+[m	[32mlastIP = CalculateHostsIP("last");[m
[32m+[m	[32m//insert into HTML[m
[32m+[m	[32mhtml_networkIp.innerHTML=networkIP.toString().replace(/,/g,"."); //regular expression to replace all occurrencies of comma[m
[32m+[m	[32mhtml_broadcastIp.innerHTML=broadcastIP.toString().replace(/,/g,".");[m
[32m+[m	[32mhtml_hostAmount.innerHTML=hostAmount.toString().replace(/,/g,".");[m
[32m+[m	[32mhtml_firstIp.innerHTML=firstIP.toString().replace(/,/g,".");[m
[32m+[m	[32mhtml_lastIp.innerHTML=lastIP.toString().replace(/,/g,".");[m
[32m+[m	[32mcalc_view[0].style.display = "block";[m
[32m+[m[32m}[m
[32m+[m[32mfunction RefreshData(){[m
[32m+[m[32mipAddress =  [document.forms["form_ip"]["ip1"].value, document.forms["form_ip"]["ip2"].value, document.forms["form_ip"]["ip3"].value, document.forms["form_ip"]["ip4"].value];[m
[32m+[m[32msubnetMask = [document.forms["form_ip"]["mask1"].value, document.forms["form_ip"]["mask2"].value, document.forms["form_ip"]["mask3"].value, document.forms["form_ip"]["mask4"].value][m
[32m+[m[32m}[m
[32m+[m[32mfunction CalculateHostAmount(){[m
[32m+[m	[32mreturn 256-subnetMask[3]-2;[m
[32m+[m[32m}[m
[32m+[m[32mfunction CalculateNetworkIP(){[m
[32m+[m	[32mvar result = new Array(4);[m
[32m+[m	[32mfor(var i=0;i<4;i++)[m
[32m+[m	[32m{[m
[32m+[m		[32mresult[i] = ToDecimal(BinaryLogicAND(ToBinary(ipAddress[i]),ToBinary(subnetMask[i])));[m
[32m+[m	[32m}[m
[32m+[m	[32mreturn result;[m
[32m+[m[32m}[m
[32m+[m[32mfunction CalculateBroadcastIP(){[m
[32m+[m	[32mvar result = new Array(4);[m
[32m+[m	[32mfor(var i=0;i<4;i++)[m
[32m+[m	[32m{[m
[32m+[m		[32mresult[i] = ToDecimal(BinaryLogicNOT(ToBinary(subnetMask[i])))+networkIP[i];[m
[32m+[m	[32m}[m
[32m+[m	[32mreturn result;[m
[32m+[m[32m}[m
[32m+[m[32mfunction CalculateHostsIP(which)[m
[32m+[m[32m{[m
[32m+[m	[32mif(which=="first") return [networkIP[0], networkIP[1], networkIP[2], networkIP[3]+1];[m
[32m+[m	[32mif(which=="last") return [broadcastIP[0], broadcastIP[1], broadcastIP[2], broadcastIP[3]-1];[m
[32m+[m[32m}[m
[32m+[m
[32m+[m[32m//BINARY CALCULATION[m
[32m+[m
[32m+[m[32mfunction ToBinary(value){	//add remaining "0" bits[m
[32m+[m	[32mvar arrayValue = 0;[m
[32m+[m	[32mvar array = new Array(8);[m
[32m+[m[41m	[m
[32m+[m	[32mif(value>=128)[m
[32m+[m	[32m{[m
[32m+[m		[32marray[0] = 1;[m
[32m+[m		[32marrayValue+= 128;[m
[32m+[m	[32m}[m
[32m+[m	[32mif(value-arrayValue>=64)[m
[32m+[m	[32m{[m
[32m+[m		[32marray[1] = 1;[m
[32m+[m		[32marrayValue+=64;[m
[32m+[m	[32m}[m
[32m+[m	[32mif(value-arrayValue>=32)[m
[32m+[m	[32m{[m
[32m+[m		[32marray[2] = 1;[m
[32m+[m		[32marrayValue+=32;[m
[32m+[m	[32m}[m
[32m+[m	[32mif(value-arrayValue>=16)[m
[32m+[m	[32m{[m
[32m+[m		[32marray[3] = 1;[m
[32m+[m		[32marrayValue+=16;[m
[32m+[m	[32m}[m
[32m+[m	[32mif(value-arrayValue>=8)[m
[32m+[m	[32m{[m
[32m+[m		[32marray[4] = 1;[m
[32m+[m		[32marrayValue+=8;[m
[32m+[m	[32m}[m
[32m+[m	[32mif(value-arrayValue>=4)[m
[32m+[m	[32m{[m
[32m+[m		[32marray[5] = 1;[m
[32m+[m		[32marrayValue+=4;[m
[32m+[m	[32m}[m
[32m+[m	[32mif(value-arrayValue>=2)[m
[32m+[m	[32m{[m
[32m+[m		[32marray[6] = 1;[m
[32m+[m		[32marrayValue+=2;[m
[32m+[m	[32m}[m
[32m+[m	[32mif(value-arrayValue>=1)[m
[32m+[m	[32m{[m
[32m+[m		[32marray[7] = 1;[m
[32m+[m		[32marrayValue+=64;[m
[32m+[m	[32m}[m
[32m+[m	[32mfor(var i=0;i<array.length;i++)[m
[32m+[m	[32m{[m
[32m+[m		[32mif(array[i]==undefined) array[i]=0;[m
[32m+[m	[32m}[m
[32m+[m	[32mreturn array;[m
[32m+[m[32m}[m
[32m+[m[32mfunction ToDecimal(arrValue) //input must be array[m
[32m+[m[32m{[m
[32m+[m	[32mvar value=0;[m
[32m+[m	[32mfor(var i=0;i<arrValue.length;i++)[m
[32m+[m	[32m{[m
[32m+[m		[32mif(i==0 && arrValue[i]==1) value+=128;[m
[32m+[m		[32mif(i==1 && arrValue[i]==1) value+=64;[m
[32m+[m		[32mif(i==2 && arrValue[i]==1) value+=32;[m
[32m+[m		[32mif(i==3 && arrValue[i]==1) value+=16;[m
[32m+[m		[32mif(i==4 && arrValue[i]==1) value+=8;[m
[32m+[m		[32mif(i==5 && arrValue[i]==1) value+=4;[m
[32m+[m		[32mif(i==6 && arrValue[i]==1) value+=2;[m
[32m+[m		[32mif(i==7 && arrValue[i]==1) value+=1;[m
[32m+[m	[32m}[m
[32m+[m	[32mreturn value;[m
[32m+[m[32m}[m
[32m+[m[32mfunction BinaryLogicAND(val1,val2) //input have 8 bit and it is string NOT array[m
[32m+[m[32m{[m
[32m+[m	[32mvar result = new Array(8);[m
[32m+[m	[32mfor(var i=0;i<result.length;i++)[m
[32m+[m	[32m{[m
[32m+[m		[32mif(val1[i]==1 && val2[i]==1) result[i]=1;[m
[32m+[m		[32melse {result[i]=0;}[m
[32m+[m	[32m}[m
[32m+[m	[32mreturn result;[m
[32m+[m[32m}[m
[32m+[m[32mfunction BinaryLogicNOT(val1)[m
[32m+[m[32m{[m
[32m+[m	[32mvar result = new Array(8);[m
[32m+[m	[32mfor(var i=0;i<result.length;i++)[m
[32m+[m	[32m{[m
[32m+[m		[32mif(val1[i]==1) result[i] = 0;[m
[32m+[m		[32melse{ result[i] = 1 }[m
[32m+[m	[32m}[m
[32m+[m	[32mreturn result;[m
[32m+[m[32m}[m
\ No newline at end of file[m
[1mdiff --git a/IPCalculator-javascript/languagemodule.js b/IPCalculator-javascript/languagemodule.js[m
[1mnew file mode 100644[m
[1mindex 0000000..800d0b7[m
[1m--- /dev/null[m
[1m+++ b/IPCalculator-javascript/languagemodule.js[m
[36m@@ -0,0 +1,13 @@[m
[32m+[m[32m//LANGUAGE MODULE[m
[32m+[m[32mif(navigator.language!="pl")[m
[32m+[m[32m{[m
[32m+[m	[32mdocument.title = "IP Calculator";[m
[32m+[m	[32mdocument.getElementsByClassName("btn_calc")[0].innerHTML = "Calculate";[m
[32m+[m	[32mdocument.getElementsByClassName("text_address")[0].innerHTML = "IP Address";[m
[32m+[m	[32mdocument.getElementsByClassName("text_address")[1].innerHTML = "Subnet Mask";[m
[32m+[m	[32mdocument.getElementsByClassName("text_address")[2].innerHTML = "Network IP";[m
[32m+[m	[32mdocument.getElementsByClassName("text_address")[3].innerHTML = "Broadcast IP";[m
[32m+[m	[32mdocument.getElementsByClassName("text_address")[4].innerHTML = "Number of hosts";[m
[32m+[m	[32mdocument.getElementsByClassName("text_address")[5].innerHTML = "First Host IP";[m
[32m+[m	[32mdocument.getElementsByClassName("text_address")[6].innerHTML = "Last Host IP";[m
[32m+[m[32m}[m
\ No newline at end of file[m
[1mdiff --git a/IPCalculator-javascript/style.css b/IPCalculator-javascript/style.css[m
[1mnew file mode 100644[m
[1mindex 0000000..3eedc01[m
[1m--- /dev/null[m
[1m+++ b/IPCalculator-javascript/style.css[m
[36m@@ -0,0 +1,95 @@[m
[32m+[m[32m@import url('https://fonts.googleapis.com/css?family=Roboto+Condensed:400,700&subset=latin-ext');[m
[32m+[m[32mbody{[m
[32m+[m	[32mmargin-left:20vw;[m
[32m+[m	[32mmargin-right:20vw;[m
[32m+[m	[32mfont-family: 'Roboto Condensed', sans-serif;[m
[32m+[m[32m}[m
[32m+[m[32minput{[m
[32m+[m[32m    width:100px;[m
[32m+[m[32m}[m
[32m+[m[32m.form-wrapper{[m
[32m+[m[32m    width: 60vw;[m
[32m+[m[32m    margin-left: auto;[m
[32m+[m[32m    margin-right: auto;[m
[32m+[m	[32mmargin-bottom: 3em;[m
[32m+[m	[32mmargin-top:1em;[m
[32m+[m[32m}[m
[32m+[m[32mheader{[m
[32m+[m	[32mheight:10vh;[m
[32m+[m	[32mwidth:100%;[m
[32m+[m[32m}[m
[32m+[m[32mh1{[m
[32m+[m[32m    text-align: center;[m
[32m+[m	[32mdisplay:inline-block;[m
[32m+[m	[32mmargin-top:0px;[m[41m	[m
[32m+[m
[32m+[m[32m}[m
[32m+[m[32m.btn_calc{[m
[32m+[m	[32mdisplay:inline-block;[m
[32m+[m	[32mheight:50%;[m
[32m+[m	[32mmargin-top:0.15em;[m
[32m+[m	[32mborder:1px solid #000f30;[m
[32m+[m	[32mborder-radius:12%;[m
[32m+[m	[32mcolor: #ffffff;[m[41m [m
[32m+[m	[32mbackground-color: #002169;[m[41m  [m
[32m+[m[32m}[m[41m [m
[32m+[m[41m [m
[32m+[m[32m.btn_calc:hover{[m[41m [m
[32m+[m[32m  color: #ffffff;[m[41m [m
[32m+[m[32m  background-color: #002C8C;[m[41m [m
[32m+[m[32m  border-color: #000F30;[m[41m [m
[32m+[m[32m}[m
[32m+[m[32m.address-wrapper{[m
[32m+[m[32m    width: max-content;[m
[32m+[m[32m    margin-bottom: 1em;[m
[32m+[m[32m    margin-left: auto;[m
[32m+[m[32m    margin-right: auto;[m
[32m+[m[32m}[m
[32m+[m[32m.address-wrapper span{[m
[32m+[m	[32mmargin-left: 0.25em;[m
[32m+[m	[32mmargin-right: 0.25em;[m
[32m+[m	[32mline-height: 2em;[m
[32m+[m[32m}[m
[32m+[m[32m.ip-input::-webkit-outer-spin-button,[m
[32m+[m[32m.ip-input::-webkit-inner-spin-button {[m
[32m+[m[32m  -webkit-appearance: none;[m
[32m+[m[32m  margin: 0;[m
[32m+[m[32m}[m
[32m+[m[32m.ip-input{[m
[32m+[m	[32m-moz-appearance:textfield;[m
[32m+[m	[32mborder:2px solid #000F30;[m
[32m+[m[32m}[m
[32m+[m[32m.text_address{[m
[32m+[m[32m    font-size:18px;[m
[32m+[m[32m}[m
[32m+[m
[32m+[m[32m.calculation-wrapper{[m
[32m+[m[32m    width: 60vw;[m
[32m+[m[32m    margin-left: auto;[m
[32m+[m[32m    margin-right: auto;[m
[32m+[m	[32mfont-size:18px;[m
[32m+[m[32m}[m
[32m+[m[32m.calculation-wrapper p{[m
[32m+[m	[32mtext-align:center;[m
[32m+[m[32m}[m
[32m+[m[32m.f-right{[m
[32m+[m	[32mfloat: right;[m
[32m+[m[32m}[m
[32m+[m[32m.f-left{[m
[32m+[m	[32mfloat: left;[m
[32m+[m[32m}[m
[32m+[m[32m.f-clear{[m
[32m+[m	[32mclear:both;[m
[32m+[m[32m}[m
[32m+[m[32mp:last-child{[m
[32m+[m	[32mfont-weight:bold;[m
[32m+[m[32m}[m
[32m+[m[32m.address-wrapper p{[m
[32m+[m	[32mdisplay:inline-block;[m
[32m+[m[32m}[m
[32m+[m[32m.address-wrapper p:first-child{[m
[32m+[m	[32mmargin-left:25%;[m
[32m+[m[32m}[m
[32m+[m[32m.address-wrapper p:last-child{[m
[32m+[m	[32mmargin-right:25%;[m
[32m+[m[32m}[m
\ No newline at end of file[m
