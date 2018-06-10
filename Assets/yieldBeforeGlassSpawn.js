#pragma strict
var amtToYd : float;
var objToEnable : GameObject; 

function Start () {
    YieldThenEnable();
}

function YieldThenEnable(){
    yield WaitForSeconds(amtToYd);
    objToEnable.SetActive(true);
}