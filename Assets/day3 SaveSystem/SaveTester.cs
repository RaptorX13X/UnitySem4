using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveTester : MonoBehaviour
{
    public SaveData saveData;
    public GameObject playerGameObject;
    
    [ContextMenu("Save")]
    public void Save()
    {
        //OnPrepareSaveData?.Invoke();
        Debug.Log("I'm saving");
        saveData.playerPosition = playerGameObject.transform.position;
        saveData.playerRotation = playerGameObject.transform.rotation;
        SerializationManager.Save("test", saveData);
    }

    [ContextMenu("Load")]
    public void Load()
    {
        Debug.Log("I'm loading");
        saveData = (SaveData)SerializationManager.Load("test");
        
        playerGameObject.transform.position = saveData.playerPosition ;
        playerGameObject.transform.rotation = saveData.playerRotation;
        //OnDataLoaded?.Invoke();
    }
}
