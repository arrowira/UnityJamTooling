using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tentacle : MonoBehaviour
{
    private GameObject player;
    [SerializeField]
    private float constraint = 2.0f;
    private float startRot = 0;
    [SerializeField]
    private bool reporter = false;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        startRot = transform.rotation.eulerAngles.z;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targ = player.transform.position;
        targ.z = 0f;

        Vector3 objectPos = transform.position;
        targ.x = targ.x - objectPos.x;
        targ.y = targ.y - objectPos.y;
       
        float angle = (Mathf.Atan2(targ.y, targ.x) * Mathf.Rad2Deg+startRot);

        

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

        if ((angle-90f)<90 && (angle-90f) > -90)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, -startRot + (angle - 90f)/constraint));
        }
        else if ((angle - 90f) < 89 && (angle - 90f) > -269)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, (-startRot + (-angle - 90f) / constraint)));
        }

       
    }
}
