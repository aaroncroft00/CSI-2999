using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timing : MonoBehaviour
{
    public float timeInterval;
    public float statusDuration;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void call(bool flag)
    {
        StartCoroutine(Repeater(flag));
    }

    IEnumerator Repeater(bool flag)
    {
        flag = true;
        
        for(int i = 0; i < statusDuration; i++)
        {
            StatusEffects.updateStatus();
            yield return new WaitForSeconds(timeInterval);
        }

        flag = false;
        
    }
}
