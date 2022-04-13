using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miscTestScript : MonoBehaviour
{

    public Timing time;
    // Start is called before the first frame update
    void Start()
    {
        time = GetComponent<Timing>();
        time.call(StatusEffects.poisonFlag);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
