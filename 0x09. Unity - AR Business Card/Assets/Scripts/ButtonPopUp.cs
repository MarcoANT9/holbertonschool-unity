using UnityEngine;
using Vuforia;

public class ButtonPopUp : MonoBehaviour, ITrackableEventHandler
{

    //================================================================================
    // Public Variables ==============================================================
    //================================================================================

    //================================================================================
    // Private Variables =============================================================
    //================================================================================
    private TrackableBehaviour mTrackableBehavior;

    //================================================================================
    // Start is called before the first frame update =================================
    //================================================================================
    void Start()
    {
        mTrackableBehavior = GetComponent<TrackableBehaviour>();
        if (mTrackableBehavior)
            mTrackableBehavior.RegisterTrackableEventHandler(this);

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
    public void OnTrackableStateChanged(
        TrackableBehaviour.Status previousStatus,
        TrackableBehaviour.Status newStatus
    )
    {
        Animator[] animationClips = GetComponentsInChildren<Animator>();

        if (newStatus == TrackableBehaviour.Status.DETECTED ||
        newStatus == TrackableBehaviour.Status.TRACKED ||
        newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            foreach (Animator component in animationClips)
				component.enabled = true;
        }

        else
        {
            foreach (Animator component in animationClips)
            {
				component.Rebind();
				component.enabled = false;
            }
        }
    }

}