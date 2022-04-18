using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    private bool playerInZone;
    [SerializeField] private Animator m_animator;

    // Start is called before the first frame update
    void Start()
    {
        m_animator = GetComponent<Animator>();
        playerInZone = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("k") && playerInZone)
        {
            m_animator.SetTrigger("DoorOPen");
        }
        else
        {
            m_animator.enabled = false;
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

}
