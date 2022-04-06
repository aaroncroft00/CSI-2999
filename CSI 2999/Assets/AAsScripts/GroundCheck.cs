using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [SerializeField] private Transform rayCastOrigin;
    [SerializeField] private Transform playerFeet;
    [SerializeField] private LayerMask layerMask;
    private RaycastHit2D Hit2D;

    private void GroundCheckMethod()
    {
        if (Hit2D != false)
        {
            Hit2D = Physics2D.Raycast(rayCastOrigin.position, -Vector2.up, 100f, layerMask);
            Vector2 temp = playerFeet.position;
            temp.y = Hit2D.point.y;
            playerFeet.position = temp;
        }
    }


    // Update is called once per frame
    void Update()
    {
        GroundCheckMethod();
    }
}
