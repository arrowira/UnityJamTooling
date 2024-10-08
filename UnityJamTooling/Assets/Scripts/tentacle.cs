using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class tentacle : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D playerRb;
    [SerializeField]
    private bool isSmallest = false;
    [SerializeField]
    private float constraint = 2.0f;
    private float startRot = 0;
    [SerializeField]
    private bool reporter = false;
    private int behave = 0;
    private Transform med;
    [SerializeField]
    private float alienType = 0;
    HP hp;
    [SerializeField]
    private float damageAmt = 20f;
    private bool canLaunch = true;
    // Start is called before the first frame update
    void Start()
    {
        
        if (isSmallest)
        {
            med = transform.parent;
        }
        player = GameObject.FindWithTag("Player");
        playerRb = player.GetComponent<Rigidbody2D>();
        hp = player.GetComponent<HP>();
        startRot = transform.rotation.eulerAngles.z;
    }
    private void endShake()
    {
        behave = 0;
    }
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player"){
            behave = 0;
            if (alienType == 0)
            {
                hp.takeDamage(damageAmt);
                if (canLaunch)
                {
                    playerRb.AddForce(transform.up * 2, ForceMode2D.Impulse);
                    Invoke("LaunchCD", 0.5f);
                }
                
            }
            if (alienType == 1)
            {
                hp.takeDamage(damageAmt/2);
                playerRb.AddForce(transform.up * 1, ForceMode2D.Impulse);
            }
            else
            {
                hp.takeDamage(damageAmt * 2);
                if (canLaunch)
                {
                    playerRb.AddForce(transform.up * 3, ForceMode2D.Impulse);
                    canLaunch= false;
                    Invoke("LaunchCD", 0.5f);
                }
                
            }
            
           
            
            Invoke("endShake", 1.0f);
        }
    }
    void LaunchCD()
    {
        canLaunch = true;
    }
    void FixedUpdate()
    {
        
            Vector3 targ = player.transform.position;
            targ.z = 0f;

            Vector3 objectPos = transform.position;
            targ.x = targ.x - objectPos.x;
            targ.y = targ.y - objectPos.y;

            float angle = (Mathf.Atan2(targ.y, targ.x) * Mathf.Rad2Deg + startRot);



            if (angle > 180)
            {
                angle = -180 + (angle - 180);
            }
            if (angle < -180)
            {
                angle = 180 - (angle + 180);
            }
            if (reporter)
            {
                Debug.Log(angle);
            }

            if ((angle - 90f) < 90 && (angle - 90f) > -90)
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, -startRot + (angle - 90f) / constraint));
            }
            else if ((angle - 90f) < 89 && (angle - 90f) > -269)
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, (-startRot + (-angle - 90f) / constraint)));
            }


        
        

    }
}
