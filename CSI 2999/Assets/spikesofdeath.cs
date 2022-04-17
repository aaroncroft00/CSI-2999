using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikesofdeath : MonoBehaviour
{
    private Health playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GameObject.FindWithTag("Player").GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerHealth.TakeDamage(150);
        }

    }
}
