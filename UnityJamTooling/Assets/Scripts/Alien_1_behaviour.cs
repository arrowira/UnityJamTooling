using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Alien_1_behaviour : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;
    [SerializeField]
    private GameObject alienMan;
    [SerializeField]
    private GameObject deathParticles;
    [SerializeField]
    private float maxSpeed = 3.0f;
    [SerializeField]
    private float speedCap = 100f;
    [SerializeField]
    private bool EliteType = false;
    [SerializeField]
    private GameObject fuelPowerUp;
    [SerializeField]
    private GameObject hpPowerUp;
    private Kills kills;
    private AUM aum;
    void Start()
    {
        
    
        aum = GameObject.FindWithTag("AudioMan").GetComponent<AUM>();
        kills = GameObject.FindWithTag("Player").GetComponent<Kills>();
        player = GameObject.FindWithTag("Player");
        rb = gameObject.GetComponent<Rigidbody2D>();
        Attack();
        
    }
    void Attack()
    {
        Vector3 targ = player.transform.position;
        targ.z = 0f;

        Vector3 objectPos = transform.position;
        targ.x = targ.x - objectPos.x;
        targ.y = targ.y - objectPos.y;

        float angle = Mathf.Atan2(targ.y, targ.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        if (rb.velocity.magnitude < speedCap)
        {
            rb.AddForce(transform.right * Random.RandomRange(1, maxSpeed), ForceMode2D.Impulse);
        }
        Invoke("Attack", 1.0f);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Debris")
        {
            Rigidbody2D DebrisRB = collision.gameObject.GetComponent<Rigidbody2D>();
            if (DebrisRB.velocity.magnitude > 18.0f){
                GameObject DP = Instantiate(deathParticles, transform.position, transform.rotation);
                if (EliteType)
                {
                    Instantiate(hpPowerUp, transform.position, hpPowerUp.transform.rotation);
                }
                else
                {
                    float j = Random.Range(0, 30);
                    if (j > 20)
                    {
                        float i = Random.Range(0, 2);
                        if (i > 1)
                        {
                            Instantiate(fuelPowerUp, transform.position, hpPowerUp.transform.rotation);
                        }
                        else
                        {
                            Instantiate(fuelPowerUp, transform.position, hpPowerUp.transform.rotation);
                        }
                    }
                    
                }
                aum.squish();
                kills.addKill();
                Destroy(alienMan);
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

    }
}
