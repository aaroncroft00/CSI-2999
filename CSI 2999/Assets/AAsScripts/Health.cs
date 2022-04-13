using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxHealth = 100;
    public float currentHealth;

    



    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if(currentHealth <= 0 )
        {
            //dead
            //Play death animation 

        }
    }
}

