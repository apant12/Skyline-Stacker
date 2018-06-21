using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name)
    {
        print("Level " + name);
        Application.LoadLevel(name);
    }

    public void quitRequest()
    {
        Application.Quit();
    }


    public void LoadNextLevel()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }


}
