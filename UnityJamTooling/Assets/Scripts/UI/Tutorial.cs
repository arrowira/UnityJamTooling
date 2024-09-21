using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    [SerializeField]
    private GameObject tutorialBoard;
    private bool boardVis = false;
    public void toggleMenu()
    {


        tutorialBoard.SetActive(true);
        boardVis = true;


    }
    public void closemenu()
    {
        tutorialBoard.SetActive(false);
        boardVis = false;
    }
}
