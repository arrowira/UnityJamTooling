using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpacePlayerAnimations : MonoBehaviour
{
    public SMovement sm;
    public rotate r;
    [SerializeField]
    private Animator anm;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void falseEverything()
    {
        anm.SetBool("isAcc", false);
        anm.SetBool("isLeft", false);
        anm.SetBool("isRight", false);
        
    }
    // Update is called once per frame
    void Update()
    {
        if ( sm.isAccelerating)
        {
            falseEverything();
            anm.SetBool("isAcc", true);
        }
        else if (r.isTurningRight){
            falseEverything();
            anm.SetBool("isRight", true);
        }
        else if (r.isTurningLeft)
        {
            falseEverything();
            anm.SetBool("isLeft", true);

        }
        else
        {
            falseEverything();
        }
    }
}
