using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    [SerializeField]
    private float selfDestructTime = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("destruct", selfDestructTime);
    }
    void destruct()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
