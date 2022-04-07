using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StatusEffects
{
    public static GameObject playerObj;
    public static StormMage statAccess;
    private static float speedStore;
    private static float jumpStore;
    public static bool weakFlag;
    public static bool MWFlag;

    static StatusEffects()
    {
        weakFlag = false;
        MWFlag = false;
        playerObj = GameObject.FindWithTag("Player");
        statAccess = playerObj.GetComponent<StormMage>();
    }

    public static void updateStatus()
    {
        switch (weakFlag)
        {
            case true:
                statAccess.m_speed = 1.0f;
                statAccess.m_jumpForce = 2.0f;
                break;
            case false:
                statAccess.m_speed = 4.0f;
                statAccess.m_jumpForce = 7.5f;
                break;
        }

        switch (MWFlag)
        {
            case true:
                statAccess.m_speed = statAccess.m_speed * - 1;
                break;
        }
    }
}  

/* To use: Set relevant flags to true or false then call StatusEffects.updateStatus(); */