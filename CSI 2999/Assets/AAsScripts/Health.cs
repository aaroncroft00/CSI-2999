using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public float maxHealth = 100;
    public float currentHealth;

    



    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if(currentHealth <= 0 )
        {

                Destroy(gameObject);
                SceneManager.LoadScene("Main_Menu");

        }
        else if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}

