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
    float clicked = 0;
    float clicktime = 0;
    float clickdelay = 0.5f;

    bool DoubleClick()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            clicked++;
            if (clicked == 1) clicktime = Time.time;
        }
        if (clicked > 1 && Time.time - clicktime < clickdelay)
        {
            clicked = 0;
            clicktime = 0;
            return true;
        }
        else if (clicked > 2 || Time.time - clicktime > 1) clicked = 0;
        return false;
    }


    private void Update()
    {

        if (DoubleClick())
        {
            if (fuel > 10)
            {
                rb.AddForce(transform.up * speed * 2, ForceMode2D.Impulse);
                fuel -= 10;
            }

            

        }
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
