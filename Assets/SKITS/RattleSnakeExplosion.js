#pragma strict
var explPref : GameObject;
private var thisTransform : Transform;

function Start(){
    thisTransform = transform;
}

function Essplode(){
    Instantiate(explPref, thisTransform.position, thisTransform.rotation);  
    this.gameObject.SetActive(false);
    
}