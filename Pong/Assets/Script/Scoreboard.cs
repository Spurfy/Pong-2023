using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    public static Scoreboard Instance;

    int p1Score;
    int p2Score;
    public int maxScore;
    public string p1winMessage;
    public string p2winMessage;

    public TextMeshProUGUI p1ScoreText;
    public TextMeshProUGUI p2ScoreText;
    public TextMeshProUGUI winMessageText;

    private void Awake()
    {
        Instance = this;
    }

    void CheckWin()
    {
        if (p1Score >= maxScore)
        {
            winMessageText.text = p1winMessage;
        }
        if (p2Score >= maxScore)
        {
            winMessageText.text = p2winMessage;
        }
        else if (p1Score < maxScore && p2Score < maxScore)
        {
            BallSpawner.Instance.SpawnBall();
        }
    }

    public void GivePointToP1()
    {
        p1Score++;
        p1ScoreText.SetText(p1Score.ToString());
        CheckWin();
    }

    public void GivePointToP2()
    {
        p2Score++;
        p2ScoreText.SetText(p2Score.ToString());
        CheckWin();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
