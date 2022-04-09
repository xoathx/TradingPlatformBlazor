/*setTitle = (title) => { document.title = title; };*/
function setTitle(title) {
    document.title = title;
}

function scrollDown(elementId) {

    var objDiv = document.getElementById(elementId);
    objDiv.scrollTop = objDiv.scrollHeight;
}

function getRandomInt(max) {
    return Math.floor(Math.random() * max);
}

//document.addEventListener("DOMContentLoaded", function () {
//    var id = getRandomInt(5);
//    var path = 'url(img/bg-main/bg-' + id + '.png)';
//    document.body.style.backgroundImage = path;
//});

window.returnArrayAsync = () => {
    DotNet.invokeMethodAsync('TradingPlatformBlazor', 'ReturnArrayAsync')
        .then(data => {
            console.log(data);
        });
};