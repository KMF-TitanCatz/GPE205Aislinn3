using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pawn : MonoBehaviour
{

    //var to hold Mover
    public Mover mover;

    //Move speed var
    public float moveSpeed;
    //turn speed var
    public float turnSpeed;
    //Sprint speed 
    public float sprintSpeed;


    // Start is called before the first frame update
    public virtual void Start()
    {   
        mover = GetComponent<Mover>();
    }

    // Update is called once per frame
    public virtual void Update()
    {
    }

    public abstract void MoveForward();
    public abstract void MoveBackward();
    public abstract void RotateClockwise();
    public abstract void RotateCounterClockwise();
    public abstract void MoveFaster();

}
