﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinMenu : MonoBehaviour
{

	//================================================================================
	// Public Variables ==============================================================
	//================================================================================

	//================================================================================
	// Private Variables =============================================================
	//================================================================================
	

	//================================================================================
	// Start is called before the first frame update =================================
	//================================================================================
	void Start()
	{
		PlayerPrefs.SetInt("currentScene", SceneManager.GetActiveScene().buildIndex);
	}

	//================================================================================
	// Update is called once per frame ===============================================
	//================================================================================
	void Update()
	{
		
	}

	//================================================================================
	// Coroutines ====================================================================
	//================================================================================


	//================================================================================    
	// Functions =====================================================================
	//================================================================================
	public void MainMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}

	public void Next()
	{
		if (PlayerPrefs.GetInt("currentScene") < 4)
			SceneManager.LoadScene(PlayerPrefs.GetInt("currentScene") + 1);
		else
			SceneManager.LoadScene(0);
	}

}