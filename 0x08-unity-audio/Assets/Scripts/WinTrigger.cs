using UnityEngine;

public class WinTrigger : MonoBehaviour
{

    //================================================================================
    // Public Variables ==============================================================
    //================================================================================
    public GameObject winCanvas;
	public GameObject timerCanvas;
	public GameObject player;


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
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Timer>().SetTimerValue(true, true);
        }
        winCanvas.SetActive(true);
		timerCanvas.SetActive(false);
		player.GetComponent<Timer>().Win();
    }

}