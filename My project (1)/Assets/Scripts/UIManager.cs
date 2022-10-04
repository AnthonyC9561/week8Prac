using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{

    static private UIManager instance;
    static public UIManager Instance
    {
        get
        {
            if (instance == null)
            {
                Debug.Log("No UIManager instance..");
            }
            return instance;
        }
    }
    //using TMPro
    [SerializeField] private TextMeshProUGUI playerOneScoreText;
    [SerializeField] private TextMeshProUGUI playerTwoScoreText;

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

    void Start()//default value of score
    {
        playerOneScoreText.text = "Player 1 Score: 0";
        playerTwoScoreText.text = "Player 2 Score: 0";

    }

    void Update()
    {
        playerOneScoreText.text = $"Player 1 Score: {ScoreKeeper.Instance.PlayerOneScore}";
        playerTwoScoreText.text = $"Player 2 Score: {ScoreKeeper.Instance.PlayerTwoScore}";

    }
}
