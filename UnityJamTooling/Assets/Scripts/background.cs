using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    private float startx;
    private float starty;
    // Start is called before the first frame update
    void Start()
    {
        startx = transform.position.x;
        starty = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(12.8f * Mathf.Floor(player.position.x/12.8f) + startx,12.8f * Mathf.Floor(player.position.y/12.8f) + starty,transform.position.z);
    }
}
