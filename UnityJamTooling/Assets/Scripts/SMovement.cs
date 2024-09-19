using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    private float maxSpeed = 3.0f;
    [SerializeField]
    private float speed = 2.0f;
    public bool isAccelerating = false;
    private float fuel = 100f;
    private float fuelConsumption = 0.1f;
    [SerializeField]
    private Image fuelBar;
    [SerializeField]
    private Image lowFuel;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (fuel < 15)
        {
            lowFuel.enabled = true;
        }
        else
        {
            lowFuel.enabled = false;
        }
        fuelBar.fillAmount = fuel / 100;
        if (Input.GetKey(KeyCode.Space) && rb.velocity.magnitude < maxSpeed && fuel > 0)
        {
            rb.AddForce(transform.up * speed);

            fuel -= fuelConsumption;
            isAccelerating= true;

        }
        else
        {
            if (fuel < 100){
                fuel += fuelConsumption*1.7f;
            }
           
            isAccelerating= false;
        }
        
    }
}
