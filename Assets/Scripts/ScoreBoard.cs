using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard
{
    private int score;
    private int kills;
    private int attempts;
    private Text scoreText;

    private ScoreBoard()
    {
        scoreText = GameObject.FindWithTag("ScoreTag").GetComponent<Text>();
    }

    private static ScoreBoard instance;

    // Score get; set
    public void AddScore(int score)
    {
        this.score += score;
        Debug.Log("score = " + this.score);
        scoreText.text = "Score: " + this.score;
       
    }
    public int GetScore()
    {
        return this.score;
    }

    // Kills get; set;
    public void AddKills(int kills)
    {
        this.kills += kills;
        
        Debug.Log("kills = " + this.kills);
    }
    public int GetKills()
    {
        return this.kills;
    }

    // Attempts get; set;
    public void AddAttempts(int attempts)
    {
        this.attempts += attempts;
         Debug.Log("attemp = " + this.attempts);
    }
    public int GetAttempts()
    {
        return this.attempts;
    }

    public static ScoreBoard GetInstance()
    {
        if(instance == null)
        {
            instance = new ScoreBoard();
        }

        return instance;
    } 
}
