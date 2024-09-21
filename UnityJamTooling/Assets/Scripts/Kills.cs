using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Kills : MonoBehaviour
{
    [SerializeField]
    private TMP_Text killsText;
    private float killamt  = 0;
    public void addKill()
    {
        killamt += 1;
        killsText.text = killamt.ToString();
    }
    
}
