using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
       
        rb.AddForce(transform.right * 20, ForceMode2D.Impulse);
        Invoke("destroyMe", 3.0f);
    }
    void destroyMe()
    {
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Player" && collision.gameObject.tag != "gunTip"){
            if (collision.gameObject.layer == 3)
            {
                
                Debris d = collision.gameObject.GetComponent<Debris>();
                d.Enlarge(3.0f);
            }
            Destroy(gameObject);
        }
    }
}
