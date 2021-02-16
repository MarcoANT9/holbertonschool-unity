using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{

    //================================================================================
    // Public Variables ==============================================================
    //================================================================================

    public Button level01;
    public Button level02;
    public Button level03;
    public Button options;
    public Button exitGame;

    //================================================================================
    // Private Variables =============================================================
    //================================================================================


    //================================================================================
    // Start is called before the first frame update =================================
    //================================================================================
    void Start()
    {
        //level01.onClick.AddListener(Playlvl1);
        //level02.onClick.AddListener(Playlvl2);
        //level03.onClick.AddListener(Playlvl3);

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

    public void Playlvl1()
    {
        SceneManager.LoadScene("Level01");
    }

    public void Playlvl2()
    {
        SceneManager.LoadScene("Level02");
    }

    public void Playlvl3()
    {
        SceneManager.LoadScene("Level03");
    }

    public void OptionsMenu()
    {
        SceneManager.LoadScene("Options");
    }

    public void QuitGame()
    {
        Debug.Log("Exited");
        Application.Quit();
    }
}