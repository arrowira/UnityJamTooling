using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    [SerializeField]
    private Image hpBar;
    private float health = 100;
    // Start is called before the first frame update
    public void takeDamage(float damage)
    {
        health -= damage;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        hpBar.fillAmount = health / 100;
        if (health != 100 )
        {
            health += 0.03f;
        }
        if (health > 100 ) {

            health = 100;
        }
        if (health < 1 ) {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }
    }
}
