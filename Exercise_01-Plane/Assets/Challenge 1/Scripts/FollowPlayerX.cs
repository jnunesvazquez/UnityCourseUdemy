using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Plane = System.Numerics.Plane;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(20, 1, 10);

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
