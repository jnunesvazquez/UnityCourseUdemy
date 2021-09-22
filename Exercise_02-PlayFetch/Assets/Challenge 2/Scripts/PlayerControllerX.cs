using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float counter = 0f;
    private float spawnInterval = 1f; 
    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && counter >= spawnInterval)
        {
            //Podemos generar un nuevo perro
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            Debug.LogFormat("Tiempo de espera entre disparos establecido en {0} segundos", spawnInterval);
            counter = 0;
        }
    }
}
