using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class DissolveObject : MonoBehaviour
{

    //================================================================================
    // Public Variables ==============================================================
    //================================================================================


    //================================================================================
    // Private Variables =============================================================
    //================================================================================

    [SerializeField] private float noiseStrength = 0.25f;
    [SerializeField] private float objectHeight = 1.0f;
    private Material material;

    //================================================================================
    // Start is called before the first frame update =================================
    //================================================================================
    private void Awake()
    {
        material = GetComponent<Renderer>().material;
    }

    //================================================================================
    // Update is called once per frame ===============================================
    //================================================================================
    private void Update()
    {
        var time = Time.time * Mathf.PI * 0.25f;

        float height = transform.position.y;

        height += Mathf.Sin(time) * (objectHeight / 2.0f);
        SetHeight(height);
    }

    //================================================================================
    // Coroutines ====================================================================
    //================================================================================


    //================================================================================    
    // Functions =====================================================================
    //================================================================================
    private void SetHeight(float height)
    {
        material.SetFloat("_CutoffHeight", height);
        material.SetFloat("_NoiseStrength", noiseStrength);
    }

}