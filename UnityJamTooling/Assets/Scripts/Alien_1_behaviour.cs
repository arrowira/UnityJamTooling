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
    // Start is called before the first frame update
    void Start()
    {
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

        rb.AddForce(transform.right * Random.RandomRange(1,3), ForceMode2D.Impulse);
        Invoke("Attack", 1.0f);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Debris")
        {
            Rigidbody2D DebrisRB = collision.gameObject.GetComponent<Rigidbody2D>();
            if (DebrisRB.velocity.magnitude > 20.0f){
                GameObject DP = Instantiate(deathParticles, transform.position, transform.rotation);
                Destroy(alienMan);
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

    }
}
