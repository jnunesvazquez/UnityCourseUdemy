using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropeller : MonoBehaviour
{
    [Range(0, 800), Tooltip("Velocidad de rotación del propeller"), SerializeField]
    public float rotationSpeed = 500f;
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate( rotationSpeed * Time.deltaTime * Vector3.forward);
    }
}
