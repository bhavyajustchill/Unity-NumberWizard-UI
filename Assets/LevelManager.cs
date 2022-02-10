using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [System.Obsolete]
    public void LoadLevel(string name)
    {
        Debug.Log("Level Load Requested for : "+name);
        Application.LoadLevel(name);
    }

    public void QuitRequest()
    {
        Debug.Log("I want to Quit!");
        Application.Quit();
    }
}
