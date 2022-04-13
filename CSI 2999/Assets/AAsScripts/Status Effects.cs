using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StatusEffects
{
    public static GameObject playerObj;
    public static StormMage statAccess;
    public static Health playerHealth;

    private static float speedStore;
    private static float jumpStore;

    public static bool weakFlag; // Weakness; Makes player move more slowly and reduces jump height.
    public static bool moonFlag; // Moonwalk; Pressing right makes you go left.
    public static bool poisonFlag; // Poison; Damages health 1 point per timer interval. WIP.
    public static bool healFlag; // Healing; Heals health one point per timer interval. WIP.

    /* To use: Set relevant flags to true or false then call StatusEffects.updateStatus(); */

    static StatusEffects()
    {
        weakFlag = false;
        moonFlag = false;
        poisonFlag = false;


        playerObj = GameObject.FindWithTag("Player");
        statAccess = playerObj.GetComponent<StormMage>();
        playerHealth = playerObj.GetComponent<Health>();

        speedStore = statAccess.m_speed;
        jumpStore = statAccess.m_jumpForce;
    }

    public static void updateStatus()
    {
        switch (weakFlag)
        {
            case true:
                statAccess.m_speed = speedStore / 2;
                statAccess.m_jumpForce = jumpStore / 4;
                break;
            case false:
                statAccess.m_speed = speedStore;
                statAccess.m_jumpForce = jumpStore;
                break;
        }

        switch (moonFlag)
        {
            case true:
                statAccess.m_speed = statAccess.m_speed * -1;
                break;
        }

        switch (poisonFlag)
        {
            case true:
                playerHealth.currentHealth -= 1;
                break;
        }

        switch (healFlag)
        {
            case true:
                playerHealth.currentHealth += 1;
                break;
        }
    }
}