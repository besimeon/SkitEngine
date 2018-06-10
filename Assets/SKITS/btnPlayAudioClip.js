#pragma strict
var audSrcRattleSnake : AudioSource;
private var btnText : UnityEngine.UI.Text;

function Start(){
    btnText = GetComponentInChildren(UnityEngine.UI.Text);
    btnText.text = audSrcRattleSnake.clip.name;
}

function RattleSnakeAudPlay(){
    audSrcRattleSnake.Play();
}
