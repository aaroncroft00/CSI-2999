using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingPad : MonoBehaviour
{
    private bool playerInZone;
    private Health playerHealth;
    public float healDelay;
    public int healAmount;
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
            playerInZone = true;
            StartCoroutine(heal());
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInZone = false;
        }
    }

    IEnumerator heal()
    {
        while (playerInZone)
        {
            playerHealth.TakeDamage(healAmount * -1);

            yield return new WaitForSeconds(healDelay);
        }
    }
}
