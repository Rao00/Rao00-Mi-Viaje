
const lista = document.getElementById('contador')
var start = document.getElementById('start') 
var stopB = document.getElementById('stop') 
var num = 0
var interval

function addNum(){
    lista.innerHTML += num + '; '
    num += 1
}

start.addEventListener('click', function()
{
    interval = setInterval(addNum, 1000)
})

stopB.addEventListener('click', function()
{
    clearInterval(interval)
})