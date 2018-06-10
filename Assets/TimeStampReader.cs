using UnityEngine;
using System.Collections;
using System.Collections.Generic;//to use lists
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class TimeStampReader : MonoBehaviour {

    Animator anim;
    public bool dontPlayAnims;

    void Awake(){
        anim = GetComponent<Animator>();
        if(!dontPlayAnims){
            StartCoroutine(Load());
        }
    }
    // called from buttons during testing:
    public void CallLoad(){
        StartCoroutine(Load());
    }

	IEnumerator Load(){
        String fileName = Application.persistentDataPath + "/" + this.gameObject.name + "timeStampInfo.dat";
        if(File.Exists(fileName)){
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(fileName, FileMode.Open);
            // the (timeStampData) preceeding bf.Deserialize "casts" the generic object into a timeStampData object:
            timeStampData ts = (timeStampData)bf.Deserialize(file);

            for(int i = 0; i<ts.paramNames.Count; i++){
                yield return new WaitForSeconds(ts.amtsToYld[i]);
                SetParameter(ts.paramNames[i], ts.paramTypes[i]);
            }
        }
    }

    void SetParameter(String paramName, String paramType){
        // Debug.Log(this.gameObject+ " " +paramName+ " paramType = " +paramType);
        anim.SetBool(paramName, true);
    }
}
