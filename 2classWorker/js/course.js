
var evt = document.createEvent("HTMLEvents");
evt.initEvent("event1", false, false);
    setTimeout("window.dispatchEvent(evt)", 1500);
var i = 0;
window.addEventListener("event1", function () {
    if (document.getElementsByClassName("unlogin").length != 0) 
    {
        location.href="https://www.2-class.com/";
    }
    else{
        document.getElementsByTagName("a")[11].click();
    }
   

});
