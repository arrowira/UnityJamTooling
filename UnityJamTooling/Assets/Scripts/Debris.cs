using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debris : MonoBehaviour
{
    private bool hasBeenEnlarged = false;
    public float speedMult = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Enlarge(float size)
    {
        if (!hasBeenEnlarged)
        {
            speedMult = 6;
            transform.localScale = new Vector3(transform.localScale.x * size, transform.localScale.y * size);
            hasBeenEnlarged = true;
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
