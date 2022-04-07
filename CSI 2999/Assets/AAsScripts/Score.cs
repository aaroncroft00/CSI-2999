using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score
{
    public static int scoreval;

    public static ScoreChange scoreText;

    static Score()
    {
        scoreval = 0;
        scoreText = GameObject.Find("UI").GetComponent<ScoreChange>();
    }

    public static void addScore(int a)
    {
        scoreval += a;

        if(scoreval > 999999)
        {
            scoreval = 999999;
        } else if(scoreval < 0)
        {
            scoreval = 0;
        }

        scoreText.updateScore();
    }
}

/* To use: Call Score.addScore(int); */
