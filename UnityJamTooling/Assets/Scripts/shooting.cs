using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shooting : MonoBehaviour
{
    [SerializeField]
    private Transform playerTransform;
    public GameObject projectilePrefab;
    [SerializeField]
    private Rigidbody2D playerRb;
    [SerializeField]
    private GameObject forceMuzzle;
    
    private Rigidbody2D bulletRb;
    [SerializeField]
    private float whichGun = 0;
    private float shockpower = 1;
    private bool shocking = false;
    [SerializeField]
    private GameObject muzzle;
    [SerializeField]
    private Image gun0;
    [SerializeField]
    private Image gun1;
    // Start is called before the first frame update
    void Start()
    {
        gun1.enabled = false;
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
            ObjectInRangeRB.AddForce(transform.right * 3 * Mathf.Floor(shockpower), ForceMode2D.Impulse);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (whichGun == 0)
            { 
                gun0.enabled = false;
                gun1.enabled = true;
                whichGun = 1;
            }
            else
            {
                gun0.enabled = true;
                gun1.enabled = false;
                whichGun = 0;
            }
        }

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
                shockpower += 1f;
            }
            
        }

        if (Input.GetKeyUp(KeyCode.Mouse0) && whichGun == 1)
        {
            shocking = true;

            GameObject forceFlash = Instantiate(forceMuzzle, transform.position, Quaternion.Euler(new Vector3(-playerTransform.rotation.eulerAngles.z, 90f, playerTransform.rotation.eulerAngles.z)));
            Invoke("endShock", 0.1f);
            if (whichGun == 1)
            {
                shockpower = 1;
            }
        }

    }
    void ShootProjectile()
    {
        GameObject muzzleFlash = Instantiate(muzzle, transform.position, Quaternion.Euler(new Vector3(-playerTransform.rotation.eulerAngles.z, 90f, playerTransform.rotation.eulerAngles.z)));
 
        GameObject projectile = Instantiate(projectilePrefab, transform.position, transform.rotation);
        bulletRb = projectile.GetComponent<Rigidbody2D>();
        bulletRb.velocity = playerRb.velocity;
        
        
    }
}
