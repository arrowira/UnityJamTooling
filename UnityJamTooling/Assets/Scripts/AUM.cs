using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AUM : MonoBehaviour
{
    public AudioSource squishSfx;
    public AudioSource PowerUpp;
    public AudioSource Oof;
    public AudioSource Op;
    public AudioSource Opp;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void squish()
    {
        squishSfx.Play();
    }
    public void PowerUp()
    {
        PowerUpp.Play();
    }
    public void FetchIpAdress()
    {
        Oof.Play();
    }
    public void ShootOpps()
    {
        Op.Play();
    }
    public void ShootOppps()
    {
        Opp.Play();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
