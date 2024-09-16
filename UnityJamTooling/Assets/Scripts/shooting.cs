using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public GameObject projectilePrefab;
    [SerializeField]
    private Rigidbody2D playerRb;
    
    private Rigidbody2D bulletRb;
    [SerializeField]
    private float whichGun = 0;
    private float shockpower = 1;
    private bool shocking = false;
    // Start is called before the first frame update
    void Start()
    {

    }
    void endShock()
    {
        shocking = false;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (shocking)
        {
            Rigidbody2D ObjectInRangeRB = collision.GetComponent<Rigidbody2D>();
            ObjectInRangeRB.AddForce(transform.right * 20 * Mathf.Floor(shockpower), ForceMode2D.Impulse);
        }
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (whichGun == 0)
            {
                ShootProjectile();
            }
            
        }
        if (Input.GetKey(KeyCode.Mouse0) && whichGun == 1)
        {
            if (whichGun == 1)
            {
                shockpower += 0.01f;
            }
            
        }

        if (Input.GetKeyUp(KeyCode.Mouse0) && whichGun == 1)
        {
            shocking = true;
            Debug.Log(shockpower);
            Invoke("endShock", 0.1f);
            if (whichGun == 1)
            {
                shockpower = 1;
            }
        }

    }
    void ShootProjectile()
    {
        
        GameObject projectile = Instantiate(projectilePrefab, transform.position, transform.rotation);
        bulletRb = projectile.GetComponent<Rigidbody2D>();
        bulletRb.velocity = playerRb.velocity;
        
        
    }
}
