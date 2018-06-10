#pragma strict
var paramName : String;
var paramType : String;
var animator : Animator;

function Awake () {
    animator = GetComponent(Animator);
}

function SetParamName(name : String){
    paramName = name;
}

function SetParamType(type : String){
    paramType = type;
}

function SetParameter(){
    switch(paramType){
        case "trigger":
            animator.SetTrigger(paramName);
            break;
        case "boolean":
            animator.SetBool(paramName, true);//for now, this script will always set to true
            break;        
        default:
            break;
    }
}