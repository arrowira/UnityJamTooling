using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnNinety : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + 90, 0f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
