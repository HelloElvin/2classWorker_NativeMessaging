var evt = document.createEvent("HTMLEvents");
evt.initEvent("event1", false, false);
setTimeout("window.dispatchEvent(evt)", 1500);
var uname;
var psw;
var i = 0;

window.addEventListener("event1", function () {
    if (document.getElementsByClassName("unlogin").length != 0) {
        if (i < arr.length) {
            setTimeout("window.dispatchEvent(evt)", arr[i]() * 1000);
            i++;
        }
    }
    else{
        chrome.runtime.sendMessage({type: "login", message: "ok"}, function(response) {
        });
        location.href="https://www.2-class.com/courses/exams/6";
    }
})

var arr = [
    function () {
        document.getElementsByClassName("unlogin")[0].firstElementChild.firstElementChild.click();
        chrome.runtime.sendMessage({ type: "account", message: "ok" }, function (response) {
            uname = response.uname;
            psw = response.psw;
        });
        return 1;
    },

    function () {
        var ac = document.getElementById("account");
        ac.onblur = function () {
            ps.value = psw;
            ps.focus();
        }
        var ps = document.getElementById("password");
        ps.onblur = function () {
            document.getElementsByClassName("ant-btn submit-btn ant-btn-primary")[0].click();
        }
        ac.value = uname;
        ac.focus();
        return 2;
    },

    function(){ chrome.runtime.sendMessage({type: "click", message: "ok"}, function(response) {
    });return 1;},
    function(){ chrome.runtime.sendMessage({type: "click", message: "ok"}, function(response) {
    });return 1;}
];


