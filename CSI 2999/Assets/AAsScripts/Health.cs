using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxHealth = 15;
    public float currentHealth;



    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    
}

