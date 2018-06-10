using UnityEngine;
using System.Collections;
using System.Collections.Generic;//to use lists
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

/*
    Code based on tut: https://unity3d.com/learn/tutorials/topics/scripting/persistence-saving-and-loading-data
    File location Unity creates playerInfo.dat to: 
        /Users/blakesimeon/Library/Application Support/BonusLevelDevelopment/Shakey The Cow/playerInfo3.dat
*/

[Serializable]
public class timeStampData{
    [SerializeField]
    // using lists: https://unity3d.com/learn/tutorials/modules/intermediate/scripting/lists-and-dictionaries
    public List<String> paramNames = new List<String>();
    public List<String> paramTypes = new List<String>();
    public List<float> amtsToYld = new List<float>(); 
}

public class TimeStampRecorder : MonoBehaviour {
    
    public BinaryFormatter bf;
    private FileStream file;
    public timeStampData ts;
    private float lastTimeStamp;
    
    
    public void CreateAndOpen(){
        lastTimeStamp = 0.0f;
        bf = new BinaryFormatter();
        String fileName = Application.persistentDataPath + "/" + this.gameObject.name + "timeStampInfo.dat";
        file = File.Create(fileName);
        ts = new timeStampData();
    }
    
    //public void SaveTimeStamp(String paramName){
    public void SaveParamName(String paramName){
        ts.paramNames.Add(paramName);
    }
    
    public void SaveParamType(String paramType){
        ts.paramTypes.Add(paramType); 
    }
    
    public void SaveTimeStamp(){
        // amtToYld is the time elapsed since last timestamp:
        float amtToYld = Time.timeSinceLevelLoad - lastTimeStamp;
        ts.amtsToYld.Add(amtToYld);
        // set new val for lastTimeStamp to current time
        lastTimeStamp = Time.timeSinceLevelLoad; 
    }
    
    public void SerializeAndSave(){
        bf.Serialize(file, ts);
        file.Close();
    }
}