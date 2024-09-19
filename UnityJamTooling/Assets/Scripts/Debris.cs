using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debris : MonoBehaviour
{
    private bool hasBeenEnlarged = false;
    public float speedMult = 1;
    private Rigidbody2D rb;
    public AudioSource Pop;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        float randTurn = Random.Range(-3, 3);
        float randMove = Random.Range(-3, 3);
        rb.AddTorque(10*randTurn);
        rb.AddForce(transform.right * 5 * randMove);
        Pop = GetComponent<AudioSource>();
        
    }
    public void Enlarge(float size)
    {
        if (!hasBeenEnlarged)
        {
            speedMult = 6;
            transform.localScale = new Vector3(transform.localScale.x * size, transform.localScale.y * size);
            hasBeenEnlarged = true;
            Pop.Play();
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
