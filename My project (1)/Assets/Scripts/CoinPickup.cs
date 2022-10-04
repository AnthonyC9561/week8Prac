using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{

    public void OnTriggerEnter(Collider collider)   
    {
        if (collider.tag == StringConstants.Player1)
        {
            ScoreKeeper.Instance.AddPlayerOneCoinScore();
            Destroy(gameObject);
        }
        if (collider.tag == StringConstants.Player2)
        {
            ScoreKeeper.Instance.AddPlayerTwoCoinScore();
            Destroy(gameObject);
        }
    }

}
