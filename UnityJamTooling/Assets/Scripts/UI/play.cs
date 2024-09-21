using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class play : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void onStart()
    {
        Debug.Log("start");
        SceneManager.LoadScene(sceneName: "player");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
