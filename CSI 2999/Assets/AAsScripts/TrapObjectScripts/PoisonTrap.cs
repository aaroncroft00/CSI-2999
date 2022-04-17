using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonTrap : MonoBehaviour
{


    public float poisonTime;
    private float poisonEndTime;
    public float poisonInterval;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player") && StatusEffects.poisonFlag == false)
        {


            StatusEffects.poisonFlag = true;
            poisonEndTime = Time.time + poisonTime;
            StartCoroutine(poison());
            
            
        }

    }   IEnumerator poison()
        {
        while(Time.time < poisonEndTime)
        {
            StatusEffects.updateHealStatus();
            yield return new WaitForSeconds(poisonInterval);

        }
        StatusEffects.poisonFlag = false;
        }


}

