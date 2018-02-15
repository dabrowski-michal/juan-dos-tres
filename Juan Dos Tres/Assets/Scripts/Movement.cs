using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public Vector3 leftPosition;
    public Vector3 rightPosition;
    public Vector3 middlePosition;
    public Vector3 finalPosition;
    public float swapTime;

    // Use this for initialization
    void Start () {
        leftPosition = new Vector3(-5,1,0);
        middlePosition = new Vector3(0, 1, 0);
        rightPosition = new Vector3(5, 1, 0);
        finalPosition = middlePosition;
    }
	
    public void ChangePositionToLeft()
    {
        finalPosition = leftPosition;
    }

    public void ChangePositionToMiddle()
    {
        finalPosition = middlePosition;
    }

    public void ChangePositionToRight()
    {
        finalPosition = rightPosition;
    }

    // Update is called once per frame
    void Update () {

        //transform.position = Vector3.Lerp(transform.position, finalPosition, Time.deltaTime * swapTime);
        transform.position = Vector3.MoveTowards(transform.position, finalPosition, Time.deltaTime * swapTime);

    }
}
