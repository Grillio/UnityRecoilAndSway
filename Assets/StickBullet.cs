using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickBullet : MonoBehaviour
{
    private Rigidbody rb;

    private float deleteVal = 5f;
    private float deleteVar = 0f;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject);
        rb.isKinematic = true;
    }

    private void Update()
    {
        deleteVar += Time.deltaTime;
        if (deleteVar > deleteVal)
        {
            deleteVar = 0;
            Destroy(gameObject);
        }
    }
}
