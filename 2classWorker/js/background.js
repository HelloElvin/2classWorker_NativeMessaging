var count=0;
var port=null;
var flag=true;
var tabId;
var isLogin=false;
var d=(new Date()).getDate();
var dp=d;
var times=0;
console.log("Hello");

connectToNativeHost("start");
chrome.runtime.onMessage.addListener(
  function(request, sender, sendResponse) {

    if(request.type=="account"){
       // console.log("account");
       times++; 
       console.log(times);
       tabId=sender.tab.id;
        if(flag&&times<10){
        sendResponse({uname:userData[count].uname,psw:userData[count].psw});
        }
    }
    if(request.type=="login")
    {
        times=0;
        count++;
        console.log(count);
        if(count>=userCount)
        {
            count=0;
            flag=false;
        }
        isLogin=true;
    }
    if (request.type == "finished") {
        setTimeout(function(){
            sendResponse({uname:userData[count].uname,psw:userData[count].psw});
            chrome.tabs.reload(tabId);
        },3000);

    }
    if (request.type == "click") {
        port.postMessage({message: "ok"});

    }

	return true;
});
chrome.tabs.onUpdated.addListener(
function(Id,changeInfo,tab)
{
    if(changeInfo.status=="complete"&&isLogin)
    {
        //if(tab.url.match("yun.zjer.cn")!=null)
        //{setTimeout(function(){chrome.tabs.update(tabId,{url:"https://ms.zjer.cn"});},1000);}
        
    }
}
);

function onDisconnected()
{
	console.log(chrome.runtime.lastError);
	console.log('disconnected from native app.');
	port = null;
}

function onNativeMessage(message) {
	console.log('recieved message from native app: ' + JSON.stringify(message));
        alert(JSON.stringify(message));
}

//connect to native host and get the communicatetion port
function connectToNativeHost(msg)
{
	var nativeHostName = "com.my_company.my_application";
	console.log(nativeHostName);
 	port = chrome.runtime.connectNative(nativeHostName);
	port.onMessage.addListener(onNativeMessage);
	port.onDisconnect.addListener(onDisconnected);
	port.postMessage({message: msg});
 } 
