using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperPower : FallingObject
{

    public override void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            managerScript.StartCoroutine("TriggerSuperPower");
        }
        Destroy(gameObject);
    }

}
