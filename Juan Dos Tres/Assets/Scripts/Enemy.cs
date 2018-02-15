using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : FallingObject
{

    public override void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            managerScript.BuildWall();
        }
        Destroy(gameObject);
    }


}
