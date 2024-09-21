using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuelUp : MonoBehaviour
{
    private SMovement sm;
    // Start is called before the first frame update
    void Start()
    {
        sm = GameObject.FindWithTag("Player").GetComponent<SMovement>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            sm.maxFuel += 15;
            Destroy(gameObject);
        }
    }
}
