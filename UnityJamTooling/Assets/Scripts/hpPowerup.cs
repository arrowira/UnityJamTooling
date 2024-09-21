using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpPowerup : MonoBehaviour
{
    private HP hp;
    public AUM Get;
    // Start is called before the first frame update
    void Start()
    {
        hp = GameObject.FindWithTag("Player").GetComponent<HP>();
        Get = GameObject.FindWithTag("AudioMan").GetComponent<AUM>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            hp.maxHP += 15;
            Get.PowerUp();
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
