using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parentRotation : MonoBehaviour
{
    [SerializeField]
    private Transform parent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = parent.rotation;
    }
}
