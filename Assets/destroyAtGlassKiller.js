#pragma strict

var spawnGlassScr : CallSpawnGlass;

function Start(){
    spawnGlassScr = GameObject.FindWithTag("glassConveyor").GetComponent(CallSpawnGlass);
}

function OnTriggerEnter2D(){
    spawnGlassScr.CallSpawnGlass();
    Destroy(this.gameObject);
}