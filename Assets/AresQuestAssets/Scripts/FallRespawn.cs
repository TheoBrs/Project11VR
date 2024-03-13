using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FallRespawn : MonoBehaviour
{
    Vector3 basePosition;
    Quaternion baseRotation;

    void Start()
    {
        basePosition = transform.position;
        baseRotation = transform.rotation;
    }


    private void OnCollisionEnter(Collision collision)
    {
        //If item collide with FallLimit, respawn item
        if(collision.gameObject.tag == "Limit")
        {
            transform.position = basePosition;
            transform.rotation = baseRotation;
        }
    }

}
