var evt = document.createEvent("HTMLEvents");
evt.initEvent("event1", false, false);
setTimeout("window.dispatchEvent(evt)", 1500);
var i = 0;
window.addEventListener("event1", function () {
    if (document.getElementsByClassName("ant-confirm-body").length != 0) {
        location.href="https://www.2-class.com/courses";
    }
    else {
        if (i < arr.length) {
            setTimeout("window.dispatchEvent(evt)", arr[i]() * 1000);
            i++;

        }
    }

})

var arr = [
    function () {
        document.getElementsByClassName("ant-btn exam-box-start ant-btn-primary")[0].click();
        return 1;
    },

    function () {
        var r = document.getElementsByClassName("ant-radio-input")[1];
        r.checked = "checked";
        r.click();
        document.getElementsByClassName("ant-btn exam-content-btn-next ant-btn-primary")[0].click();
        return 1;
    },

    function () {
        var r = document.getElementsByClassName("ant-radio-input")[1];
        r.checked = "checked";
        r.click();
        document.getElementsByClassName("ant-btn ant-btn-primary")[0].click();
        return 1;
    },

    function () {
        var r = document.getElementsByClassName("ant-radio-input")[2];
        r.checked = "checked";
        r.click();
        document.getElementsByClassName("ant-btn ant-btn-primary")[0].click();
        return 1;
    },
    function () {
        var r = document.getElementsByClassName("ant-radio-input")[1];
        r.checked = "checked";
        r.click();
        document.getElementsByClassName("ant-btn ant-btn-primary")[0].click();
        return 1;
    },
    function () {
        var r = document.getElementsByClassName("ant-radio-input")[3];
        r.checked = "checked";
        r.click();
        document.getElementsByClassName("ant-btn ant-btn-primary")[0].click();
        return 1;
    },
    function () { location.href = "https://www.2-class.com/courses/exams/9"; }
];
