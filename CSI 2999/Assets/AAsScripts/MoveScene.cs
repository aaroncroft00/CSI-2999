using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    private bool playerInZone;
    [SerializeField] private string newLevel;

    private void Start()
    {
        playerInZone = false;
    }

    private void Update()
    {
        if(Input.GetKeyDown("t") && playerInZone)
        {
            UnityDidntLetMeUseTiming.endLevelScore();
            SceneManager.LoadScene(newLevel);
            Debug.Log("debugging debugger");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInZone = true;
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInZone = false;
        }
    }


    //[SerializeField] private string newLevel;

    //private void OnTriggerEnter2D(Collider2D other)
   // {
   //     if(other.CompareTag("Player"))
    //    {
     //       SceneManager.LoadScene(newLevel);
     //   }
   // }




}
