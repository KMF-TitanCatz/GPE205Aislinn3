using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TestPawn : MonoBehaviour
{

    //Move speed var
    public float moveSpeed;
    //turn speed var
    public float turnSpeed;


    // Start is called before the first frame update
    void Start()
    {       
    }

    // Update is called once per frame
    void Update()
    {
    }

    public abstract void MoveForward();
    public abstract void MoveBackward();
    public abstract void RotateClockwise();
    public abstract void RotateCounterClockwise();

}
