using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    [SerializeField]
    private Transform rotCheck;
    [SerializeField]
    private float speed;
    public bool isTurningRight, isTurningLeft = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if I need to rotate
        if (Mathf.Floor(gameObject.transform.rotation.eulerAngles.z/5) != Mathf.Floor(rotCheck.rotation.eulerAngles.z/5))
        {
            
            
            if(transform.rotation.eulerAngles.z < 90 && rotCheck.rotation.eulerAngles.z > 270)
            {
                gameObject.transform.Rotate(new Vector3(0, 0, -speed));
                isTurningRight = true;
                isTurningLeft = false;
            }
            else if (rotCheck.rotation.eulerAngles.z < 90 && transform.rotation.eulerAngles.z > 270){
                gameObject.transform.Rotate(new Vector3(0, 0, speed));
                isTurningRight = false;
                isTurningLeft = true;
            }
            else
            {
                if (Mathf.Abs(transform.rotation.eulerAngles.z - rotCheck.rotation.eulerAngles.z) < 180)
                {
                    if (transform.rotation.eulerAngles.z < rotCheck.rotation.eulerAngles.z)
                    {
                        gameObject.transform.Rotate(new Vector3(0, 0, speed));
                        isTurningRight = false;
                        isTurningLeft = true;
                    }
                    else
                    {
                        gameObject.transform.Rotate(new Vector3(0, 0, -speed));
                        isTurningRight = true;
                        isTurningLeft = false;
                    }
                    
                }
                else
                {
                    if (transform.rotation.eulerAngles.z < rotCheck.rotation.eulerAngles.z)
                    {
                        gameObject.transform.Rotate(new Vector3(0, 0, -speed));
                        isTurningRight = true;
                        isTurningLeft = false;
                    }
                    else
                    {
                        gameObject.transform.Rotate(new Vector3(0, 0, speed));
                        isTurningRight = false;
                        isTurningLeft = true;
                    }
                }
               

            }
           
           
        }
        else
        {
            isTurningRight = false;
            isTurningLeft = false;
        }
    }
}
