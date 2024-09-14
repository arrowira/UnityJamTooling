using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    [SerializeField]
    private Transform rotCheck;
    [SerializeField]
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if I need to rotate
        if (Mathf.Floor(gameObject.transform.rotation.eulerAngles.z) != Mathf.Floor(rotCheck.rotation.eulerAngles.z))
        {
            Debug.Log(rotCheck.rotation.eulerAngles.z);
            Debug.Log(transform.rotation.eulerAngles.z);
            if(transform.rotation.eulerAngles.z < 90 && rotCheck.rotation.eulerAngles.z > 270)
            {
                gameObject.transform.Rotate(new Vector3(0, 0, -speed));
            }
            else if (rotCheck.rotation.eulerAngles.z < 90 && transform.rotation.eulerAngles.z > 270){
                gameObject.transform.Rotate(new Vector3(0, 0, speed));
            }
            else
            {
                if (transform.rotation.eulerAngles.z < rotCheck.rotation.eulerAngles.z )
                {
                    gameObject.transform.Rotate(new Vector3(0, 0, speed));
                }
                else
                {
                    gameObject.transform.Rotate(new Vector3(0, 0, -speed));
                }
               

            }
           
           
        }
    }
}
