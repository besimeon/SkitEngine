#pragma strict
var amtTmBtwSpawn : float;
var glassPrefab : GameObject;
var glassSpawn : Transform;

function CallSpawnGlass(){
    SpawnGlass();
}

function SpawnGlass(){
    yield WaitForSeconds(amtTmBtwSpawn);
    var newGlass = Instantiate(glassPrefab, glassSpawn.position, this.transform.rotation);
}