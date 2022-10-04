using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{

    public void OnTriggerEnter(Collider collider)   
    {//changed so triggers work on only either player 1 and 2
        if (collider.tag == StringConstants.Player1)
        {
            ScoreKeeper.Instance.AddPlayerOneCoinScore();
            Destroy(gameObject);
        }
        else if (collider.tag == StringConstants.Player2)
        {
            ScoreKeeper.Instance.AddPlayerTwoCoinScore();
            Destroy(gameObject);
        }
    }

}
