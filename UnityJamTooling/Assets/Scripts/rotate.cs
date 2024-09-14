using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    [SerializeField]
    private Transform rotCheck;
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
            Debug.Log(transform.rotation.eulerAngles.z);
            if(Mathf.Abs(transform.rotation.eulerAngles.z) > Mathf.Abs(rotCheck.rotation.eulerAngles.z) && transform.rotation.eulerAngles.z < 355f && transform.rotation.eulerAngles.z > 10f)
            {
                gameObject.transform.Rotate(new Vector3(0, 0, -3f));

            }
            else
            {
              
               
                gameObject.transform.Rotate(new Vector3(0, 0, 3f));
               
               
            }
           
        }
    }
}
