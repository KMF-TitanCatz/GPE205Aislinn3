using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMover : Mover
{
    //var for Rigidbody component
    private Rigidbody rb;

    // Start is called before the first frame update
    public override void Start()
    {
        //get rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    //move function for tank
    public override void Move(Vector3 direction, float speed)
    {
        Vector3 moveVector = direction.normalized * speed * Time.deltaTime;
        rb.MovePosition(rb.position + moveVector);
    }

    //rotate function for tank
    public override void Rotate(float turnSpeed)
    {
        float rotate = turnSpeed * Time.deltaTime;
        transform.Rotate(0, rotate, 0, Space.Self);

    }

    //sprint
    public override void Sprint(Vector3 direction, float speed)
    {
        Vector3 sprintVector = direction.normalized * speed * Time.deltaTime;
        rb.MovePosition(rb.position + sprintVector);
    }
}
