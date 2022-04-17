using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UnityDidntLetMeUseTiming
{
    public static float startTime;
    public static int seconds;
    public static int scoremult;

    public static void getStartTime()
    {
        startTime = Time.time;
    }

    public static void endLevelScore()
    {
        seconds = (int)(Time.time - startTime);
        scoremult = 100 - seconds;
        if (scoremult < 0)
        {
            scoremult = 0;
        }
        Score.addScore(50 * scoremult);
    }
}
