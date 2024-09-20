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
    public float maxHP = 100;
    private bool damageCooldown = false;
    // Start is called before the first frame update
    public void takeDamage(float damage)
    {
        if (!damageCooldown)
        {
            health -= damage;
            damageCooldown = true;
            Invoke("endDamageCD", 0.5f);
        }

        
    }
    void endDamageCD()
    {
        damageCooldown= false;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        hpBar.fillAmount = health / maxHP;
        if (health != maxHP )
        {
            health += 0.03f;
        }
        if (health > maxHP ) {

            health = maxHP;
        }
        if (health < 1 ) {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }
    }
}
