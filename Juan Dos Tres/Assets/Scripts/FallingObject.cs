using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FallingObject : MonoBehaviour {

    public int score;
    public GameObject gameManager;
    public MainManager managerScript;
    public float fallingSpeed = 20;

    public void Start () {
        managerScript = gameManager.GetComponent<MainManager>();
    }

    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * fallingSpeed, Space.World);
    }

    public abstract void OnTriggerEnter(Collider other);
}
