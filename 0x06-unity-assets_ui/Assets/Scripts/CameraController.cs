using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    //================================================================================
    // Public Variables ==============================================================
    //================================================================================
    public int invertedY = 1;
    public Transform target;

    //================================================================================
    // Private Variables ==============================================================
    //================================================================================
    private const float turn_speed = 150f;
    private const float vert_speed = 150f;
    private Quaternion rotation;
    private Vector3 cameraRotation;
    private Vector3 offset = new Vector3(0f, 2.5f, -6.25f);



    //================================================================================
    // Start is called before the first frame update =================================
    //================================================================================
    void Start()

    {
        setCameraTarget(target);
    }

    //================================================================================
    // Update is called once per frame ===============================================
    //================================================================================
    void FixedUpdate()
    {
        rotation = Quaternion.identity;
        rotation = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * vert_speed * Time.deltaTime * invertedY, Vector3.right);
        offset = rotation * offset;
        transform.position = target.position + offset;

        if (Input.GetKey(KeyCode.Mouse1))
            rotation = Quaternion.AngleAxis(-Input.GetAxis("Mouse X") * turn_speed * Time.deltaTime, Vector3.up);
        else
            rotation = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turn_speed * Time.deltaTime, Vector3.up);

        offset = rotation * offset;
        transform.position = target.position + offset;
        transform.LookAt(target);
    }

    //================================================================================
    // Coroutines & Other Functions ==================================================
    //================================================================================

    // Sets the target for the camera
    public void setCameraTarget(Transform t)
    {
        if (t != null)
            target = t;
        else
            Debug.LogError("Men comportsese");
    }

        public void invertYAxis()
    {
        invertedY = -1;
    }

}
