﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
   public void LoadLevel(string name) {
        Debug.Log("Level load requested for: " + name);
        //Application.LoadLevel(name);
        SceneManager.LoadScene(name);
        
    }

    public void QuitRequest() {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
