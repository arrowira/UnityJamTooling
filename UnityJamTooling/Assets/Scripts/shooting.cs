using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public GameObject projectilePrefab;
    [SerializeField]
    private Rigidbody2D playerRb;
    
    private Rigidbody2D bulletRb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ShootProjectile();
        }

    }
    void ShootProjectile()
    {
        
        GameObject projectile = Instantiate(projectilePrefab, transform.position, transform.rotation);
        bulletRb = projectile.GetComponent<Rigidbody2D>();
        bulletRb.velocity = playerRb.velocity;
        
        
    }
}
