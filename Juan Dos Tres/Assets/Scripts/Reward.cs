using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reward : FallingObject
{
    public override void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            print("Collider works");
            managerScript.IncreaseScore(score);
        }
        Destroy(gameObject);
    }

}
