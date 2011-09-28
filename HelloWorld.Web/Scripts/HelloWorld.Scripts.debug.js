//! HelloWorld.Scripts.debug.js
//

(function() {

Type.registerNamespace('HelloWorld.Scripts');

////////////////////////////////////////////////////////////////////////////////
// HelloWorld.Scripts._helloWorldPage



(function () {
    var helloButton = document.getElementById('helloButton');
    helloButton.addEventListener('click', function() {
        var nameTextBox = document.getElementById('nameTextBox');
        var xhr = new XMLHttpRequest();
        xhr.open('GET', '/Home/World/' + encodeURIComponent(nameTextBox.value));
        xhr.onreadystatechange = function() {
            if (xhr.readyState === 4) {
                var data = eval('(' + xhr.responseText + ')');
                var greeting = String.format('{0}{1}...', data.Greeting, data.TimeStamp);
                alert(greeting);
            }
        };
        xhr.send();
    }, false);
})();
})();

//! This script was generated using Script# v0.7.3.0
