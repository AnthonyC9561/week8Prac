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
    private int playerOneScore; //current player score
    
    public int PlayerOneScore //property to read score
    {
        get
        {
            return playerOneScore;
        }
    }

    private int playerTwoScore;
    public int PlayerTwoScore //property to read score
    {
        get
        {
            return playerTwoScore;
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
    public void AddPlayerOneCoinScore()
    {
        playerOneScore += coinScore;
    }
    

    //to access method ScoreKeeper.Instance.addCoinScore();
    public void AddPlayerTwoCoinScore()
    {
        playerTwoScore += coinScore;
    }

}


