using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject spawnable;
    [SerializeField]
    private float range = 30;
    
    [SerializeField]
    private float spawnRate = 10f;
    private bool canInvoke = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void SpawnEnemy()
    {
        while (true)
        {
            float xcord = Random.RandomRange(-50, 50);
            float ycord = Random.RandomRange(-50, 50);
            if (Mathf.Sqrt(xcord*xcord + ycord*ycord) > range){
                Instantiate(spawnable, new Vector3(transform.position.x + xcord, transform.position.y + ycord), transform.rotation);
                break;
            }
        }
        canInvoke = true;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (canInvoke)
        {
            Invoke("SpawnEnemy", spawnRate);
            canInvoke = false;
        }
    }
}
