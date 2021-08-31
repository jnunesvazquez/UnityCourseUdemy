using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    [Range(0, 20), Tooltip("Velocidad del avión"), SerializeField]
    public float speed = 15f;
    [Range(0, 180), Tooltip("Velocidad de rotacion del avión"), SerializeField]
    public float rotationSpeed = 90f;
    public float verticalInput;

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(speed * Time.deltaTime * Vector3.forward);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate( rotationSpeed * verticalInput * Time.deltaTime * Vector3.left);
    }
}
