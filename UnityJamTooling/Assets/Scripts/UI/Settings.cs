using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Settings : MonoBehaviour
{
    [SerializeField]
    private GameObject settingBoard;
    private bool boardVis = false;
    public void toggleMenu()
    {
      
        
            settingBoard.SetActive(true);
            boardVis= true;
        
        
    }
    public void closemenu()
    {
        settingBoard.SetActive(false);
        boardVis = false;
    }
    
}
