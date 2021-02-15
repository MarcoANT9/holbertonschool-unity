﻿using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    //================================================================================
    // Public Variables ==============================================================
    //================================================================================

    public float playerSpeed = 10.0f;
    public float jumpHeight = 2.0f;
    //public Timer crono;
    public Transform cam;

    //================================================================================
    // Private Variables =============================================================
    //================================================================================
    private bool groundPlayer;
    private CharacterController pController;
    private float gravityValue;
    private Vector3 playerVelocity;

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
 
        // Check if player is grounded
        groundPlayer = pController.isGrounded;
        if (groundPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0.0f;
        }


        // Player Movement
        Vector3 move = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical")).normalized;
        if (move.magnitude >= 0.1f)
        {
            float angle = Mathf.Atan2(move.x, move.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 movedir = Quaternion.Euler(0f, angle, 0f) * Vector3.forward;
            pController.Move(movedir.normalized * playerSpeed * Time.deltaTime);
        }


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
