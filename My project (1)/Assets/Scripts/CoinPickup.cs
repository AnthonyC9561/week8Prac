using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
<<<<<<< Updated upstream
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
 public void OnTriggerEnter(Collider collider)
    {
                Destroy(gameObject);
=======
    
 public void OnTriggerEnter(Collider collider)
    {
        ScoreKeeper.Instance.addCoinScore();
        Destroy(gameObject);
>>>>>>> Stashed changes
    }

}
