using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class setKills : MonoBehaviour
{
    private TMP_Text Text;
    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<TMP_Text>();
        Text.text = StaticData.dataToKeep.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
