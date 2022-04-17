using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaknessTrap : MonoBehaviour
{
    public float weaknessTime;
    private float weaknessEndTime;
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

        if (other.CompareTag("Player") && StatusEffects.weakFlag == false)
        {


            StatusEffects.weakFlag = true;
            StatusEffects.updateStatus();
            weaknessEndTime = Time.time + weaknessTime;
            StartCoroutine(weak());


        }

    }
    IEnumerator weak()
    {
        while (Time.time < weaknessEndTime)
        {
            yield return new WaitForSeconds(1);
        }
        StatusEffects.weakFlag = false;
        StatusEffects.updateStatus();
    }


}
