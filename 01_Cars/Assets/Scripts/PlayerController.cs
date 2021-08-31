using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Propiedades
    //[HideInInspector]
    [Range(0, 20), Tooltip("Velocidad lineal máxima del coche"), SerializeField]
    private float celerity = 10;
    [Range(0, 90), Tooltip("Velocidad de giro máxima del coche"), SerializeField]
    private float turnSpeed = 50;
    private float horizontalInput, verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        //Mostrar una String por consola
        Debug.Log("Esto es el metodo Start del PlayerControler" + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Esto es el metodo Update del PlayerControler" + gameObject.name);
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        Debug.Log(horizontalInput);
        //Transladar un objeto
        // s = s0 + v * t * (d)
        transform.Translate( celerity * verticalInput * Time.deltaTime * Vector3.forward);
        transform.Rotate(turnSpeed * horizontalInput * Time.deltaTime * Vector3.left);
    }
}