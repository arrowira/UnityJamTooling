using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpPowerup : MonoBehaviour
{
    private HP hp;
    // Start is called before the first frame update
    void Start()
    {
        hp = GameObject.FindWithTag("Player").GetComponent<HP>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            hp.maxHP += 15;
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
