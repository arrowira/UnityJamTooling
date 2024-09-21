using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AUM : MonoBehaviour
{
    public AudioSource squishSfx;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void squish()
    {
        squishSfx.Play();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
