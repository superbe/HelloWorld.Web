// HelloWorld.Scripts.js
(function(){
Type.registerNamespace('HelloWorld.Scripts');(function(){var $0=document.getElementById('helloButton');$0.addEventListener('click',function(){
var $1_0=document.getElementById('nameTextBox');var $1_1=new XMLHttpRequest();$1_1.open('GET','/Home/World/'+encodeURIComponent($1_0.value));$1_1.onreadystatechange=function(){
if($1_1.readyState===4){var $2_0=eval('('+$1_1.responseText+')');var $2_1=String.format('{0}{1}...',$2_0.Greeting,$2_0.TimeStamp);alert($2_1);}};$1_1.send();},false);})();
})();// This script was generated using Script# v0.7.3.0
