using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{   
    public int health;
    public float speed;
    private float dazedTime;
    public float startDazedTime;
    public Slider healthBar;

    private Animator anim;





    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("isRunning", true);
        
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = health;

        if(dazedTime <= 0){
            speed = 5;
        } else {
            speed = 0;
            dazedTime -= Time.deltaTime;
        }
        
        if(health <= 0){
            Destroy(gameObject);
        }
        
    }
    public void TakeDamage(int damage){
        dazedTime = startDazedTime;
        health -= damage;
        Debug.Log("damage Taken");
    }
}
