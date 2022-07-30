using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Controller
{
    //var
    public KeyCode moveForwardKey;
    public KeyCode moveBackwardsKey;
    public KeyCode rotateClockwiseKey;
    public KeyCode rotateCounterClockwiseKey;
    public KeyCode sprintKey;

    // Start is called before the first frame update
    public override void Start()
    {
        //if there is a gamemanager
        if (GameManager.instance != null)
        {
            //and iof it tracks player(s)
            if (GameManager.instance.players != null)
            {
                //register with the gamemanager
                GameManager.instance.players.Add(this);
            }
        }

        //run start function from parent class
        base.Start();
    }

    public void OnDestroy()
    {
        //if there is a game manager
        if (GameManager.instance != null)
        {
            //and if it tracks player(s)
            if (GameManager.instance.players != null)
            {
                GameManager.instance.players.Remove(this);  
            }
        }
    }

    // Update is called once per frame
    public override void Update()
    {
        //Process keyboard inputs
        ProcessInputs();

        //run update function from parent class
        base.Update();
    }

    public override void ProcessInputs()
    {
        if (Input.GetKey(moveForwardKey))
            {
            pawn.MoveForward();
            }

        if (Input.GetKey(moveBackwardsKey))
            {
            pawn.MoveBackward();
            }

        if (Input.GetKey(rotateClockwiseKey))
            {
            pawn.RotateClockwise();
            }

        if (Input.GetKey(rotateCounterClockwiseKey))
            {
            pawn.RotateCounterClockwise();
            }

        if (Input.GetKey(sprintKey))
        {
            pawn.MoveFaster();
        }
    }
}
