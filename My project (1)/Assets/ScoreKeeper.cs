using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    static private ScoreKeeper instance;
    static public ScoreKeeper Instance
    {
        get
        {
            if (instance == null)
            {
                Debug.Log("no instance of ScoreKeeper...");
            }
            return instance;
        }
    }

    [SerializeField] private int coinScore = 100;
    private int score;
    public int Score
    {
        get
        {
            return score;
        }
    }

    public void addCoinScore()
    {
        score += coinScore;
    }

}
