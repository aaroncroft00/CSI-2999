using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreChange : MonoBehaviour
{
    public Text scoretext;
    // Start is called before the first frame update
    void Start()
    {
        updateScore();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void updateScore()
    {
        scoretext.text = $"{Score.scoreval}";
    }
}