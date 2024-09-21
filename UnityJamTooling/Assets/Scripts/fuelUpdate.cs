using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuelUpdate : MonoBehaviour
{
    [SerializeField]
    private RectTransform rt;
    [SerializeField]
    private SMovement sm;
    [SerializeField]
    private HP hp;
    [SerializeField]
    private int type = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (type == 0)
        {
            rt.anchoredPosition = new Vector3(180 + (hp.maxHP-100)*1.5f, rt.anchoredPosition.y);
            rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, hp.maxHP * 3);
        }
        if (type == 1)
        {
            rt.anchoredPosition = new Vector3(180 + (sm.maxFuel - 100) * 1.5f, rt.anchoredPosition.y);
            rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, sm.maxFuel * 3);
        }
    }
}
