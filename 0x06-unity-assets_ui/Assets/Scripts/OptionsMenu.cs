﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{

	//================================================================================
	// Public Variables ==============================================================
	//================================================================================
	public Button backButton;
	public Button applyButton;
	public Slider bgmSlider;
	public Slider sfxSlider;
	public Toggle invertYAxis;

	//================================================================================
	// Private Variables =============================================================
	//================================================================================
	

	//================================================================================
	// Start is called before the first frame update =================================
	//================================================================================
	void Start()
	{
		

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

	public void LoadMainMenu()
	{
		if (invertYAxis.isOn)
			invertYAxis.isOn = false;
		
		
	}

	public void applyMainMenu()
	{
		
	}

}