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

    }

    // Update is called once per frame
    void Update()
    {
        //Process keyboard inputs
        ProcessInputs();

    }

    public override void ProcessInputs()
    {
        if (Input.GetKey(moveForwardKey))
            {
            testPawn.MoveForward();
            }

        if (Input.GetKey(moveBackwardsKey))
            {
            testPawn.MoveBackward();
            }

        if (Input.GetKey(rotateClockwiseKey))
            {
            testPawn.RotateClockwise();
            }

        if (Input.GetKey(rotateCounterClockwiseKey))
            {
            testPawn.RotateCounterClockwise();
            }
    }
}
