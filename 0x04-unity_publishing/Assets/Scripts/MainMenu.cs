﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class MainMenu : MonoBehaviour
{
    //================================================================================
    // Public Variables ==============================================================
    //================================================================================
    public Button playButton;
    public Button quitButton;
    public Material trapMat;
    public Material goalMat;
    public Toggle colorblindMode;


    //================================================================================
    // Private Variables =============================================================
    //================================================================================

    //================================================================================
    // Start is called before the first frame update =================================
    //================================================================================
    void Start()
    {
        playButton.onClick.AddListener(PlayMaze);
        quitButton.onClick.AddListener(QuitMaze);
    }

    //================================================================================
    // Update is called once per frame ===============================================
    //================================================================================
    void FixedUpdate()
    {
        
    }

    //================================================================================
    // Other Functions ===============================================================
    //================================================================================
    // Start the game
    public void PlayMaze()
    {
        SceneManager.LoadScene("maze");
        if (colorblindMode.isOn)
        {
            goalMat.color = Color.blue;
            trapMat.color = new Color32(255, 112, 0, 1);
        }
        else
        {
            goalMat.color = Color.green;
            trapMat.color = Color.red;
        }
        
    }
    // Ends the game...
    public void QuitMaze()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }


}
