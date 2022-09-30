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
    [SerializeField] private TextMeshProUGUI scoreText;


    void Start()//default value of score
    {
        scoreText.text = "Score: 0";
    }

    void Update()
    {
        scoreText.text = $"Score: {ScoreKeeper.Instance.Score}";
    }
}
