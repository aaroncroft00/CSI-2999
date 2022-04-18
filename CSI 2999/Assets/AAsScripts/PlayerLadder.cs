using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLadder : MonoBehaviour
{
    [SerializeField]
    private StormMage player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Ladder>())
        {
            player.ClimbingAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.GetComponent<Ladder>())
        {
            player.ClimbingAllowed = false;
        }
    }
}
