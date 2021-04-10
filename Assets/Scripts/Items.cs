using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Items : MonoBehaviour
{ 
    public string LevelName;
    void OnCollisionEnter(Collision OtherObject)
    {   
        Debug.Log( "Colidiu!");
        SceneManager.LoadScene(LevelName);


    }
}
