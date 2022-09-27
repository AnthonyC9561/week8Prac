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

    [SerializeField] private TextMeshProUGUI scoreText;


    void Start()
    {

    }

    void Update()
    {

    }
}
