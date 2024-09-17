using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField]
    private GameObject spawnable;
    [SerializeField]
    private float rangex = 100;
    [SerializeField]
    private float rangey = 100;
    [SerializeField]
    private int spawnAmt = 10;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < spawnAmt; i++)
        {
            Instantiate(spawnable, new Vector3(transform.position.x - Random.RandomRange(-rangex / 2, rangex / 2), transform.position.y - Random.RandomRange(-rangey / 2, rangey / 2)), transform.rotation);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
