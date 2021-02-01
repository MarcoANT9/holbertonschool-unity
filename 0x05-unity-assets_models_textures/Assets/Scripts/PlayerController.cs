using UnityEngine;


public class PlayerController : MonoBehaviour
{
    //================================================================================
    // Public Variables ==============================================================
    //================================================================================

    public float playerSpeed = 10.0f;
    public float jumpHeight = 5.0f;

    //================================================================================
    // Private Variables ==============================================================
    //================================================================================
    private CharacterController pController;
    private Vector3 playerVelocity;
    private bool groundPlayer;
    private float gravityValue;


    //================================================================================
    // Start is called before the first frame update =================================
    //================================================================================
    void Start()

    {
        pController = GetComponent<CharacterController>();
    }

    //================================================================================
    // Update is called once per frame ===============================================
    //================================================================================
    void FixedUpdate()
    {
        groundPlayer = pController.isGrounded;
        if (groundPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0.0f;
        }
    
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //pController.Move(Camera.main.transform.TransformDirection(move * Time.deltaTime * playerSpeed));
        
        pController.Move(move * playerSpeed * Time.deltaTime);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;

        }

        if (transform.position.y < 0)
            gravityValue = -5.1f;
        else
            gravityValue = -9.81f;

        if (Input.GetKey("space") && groundPlayer)
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);

        playerVelocity.y += gravityValue * Time.deltaTime;
        pController.Move(playerVelocity * Time.deltaTime);

        if (transform.position.y <= -20)
            transform.position = new Vector3(0, 5, 0);

    }

    //================================================================================
    // Coroutines ====================================================================
    //================================================================================

    //================================================================================
    // Functions =====================================================================
    //================================================================================


}
