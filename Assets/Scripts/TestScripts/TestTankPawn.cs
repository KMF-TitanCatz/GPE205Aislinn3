using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTankPawn : TestPawn
{
    // Start is called before the first frame update
    void Start()
    {
        //base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        //base.Start();
    }

    //Move forward function
    public override void MoveForward()
    {
        Debug.Log("Move Forward");
    }

    //Move backward function
    public override void MoveBackward()
    {
        Debug.Log("Move Backward");
    }

    //Turn clockwise function
    public override void RotateClockwise()
    {
        Debug.Log("Rotate Clockwise");
    }

    //Turn counter clockwise function
    public override void RotateCounterClockwise()
    {
        Debug.Log("Rotate Counter Clockwise");
    }
}
