using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{

    public void OnTriggerEnter(Collider collider)
    {
        ScoreKeeper.Instance.addCoinScore();
        Destroy(gameObject);
    }

}
