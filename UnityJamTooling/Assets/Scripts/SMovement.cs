using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    private float maxSpeed = 3.0f;
    [SerializeField]
    private float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) && rb.velocity.magnitude < maxSpeed)
        {
            rb.AddForce(transform.up * speed);
        }
        rb.AddForce(-transform.up * 0.0001f);
    }
}
