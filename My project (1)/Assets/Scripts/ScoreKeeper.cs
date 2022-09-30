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
    private int score; //current player score
    public int Score //property to read score
    {
        get
        {
            return score;
        }
    }

    void Awake()
    {
        {
            if (instance != null)
            {
                Destroy(instance);
            }
            else
            {
                instance = this;
            }
        }
    }
    
    //to access method ScoreKeeper.Instance.addCoinScore();
    public void addCoinScore()
    {
        score += coinScore;
    }

}
