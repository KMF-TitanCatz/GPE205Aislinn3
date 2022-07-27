using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayerController : TestController
{

    public KeyCode moveForwardKey;
    public KeyCode moveBackwardsKey;
    public KeyCode rotateClockwiseKey;
    public KeyCode rotateCounterClockwiseKey;

    // Start is called before the first frame update
    void Start()
    {
        //base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        //Process keyboard inputs
        ProcessInputs();

        //base.Update();
    }

    public override void ProcessInputs()
    {
        if (Input.GetKey(moveForwardKey))
            {
            TestPawn.MoveForward();
            }

        if (Input.GetKey(moveBackwardsKey))
            {
            TestPawn.MoveBackward();
            }

        if (Input.GetKey(rotateClockwiseKey))
            {
            TestPawn.RotateClockwise();
            }

        if (Input.GetKey(rotateCounterClockwiseKey))
            {
            TestPawn.RotateCounterClockwise();
            }
    }
}
