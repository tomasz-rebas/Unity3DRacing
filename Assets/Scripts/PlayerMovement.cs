using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 500f;

    void Start()
    {
        Debug.Log("Hello Word!");
    }

    void Update()
    {
        rb.AddForce(0, 0, speed * Time.deltaTime);
    }
}
