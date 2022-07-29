using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    public abstract void Start();

    //Movement foward/backward function
    public abstract void Move(Vector3 direction, float speed);

    //Rotate Function
    public abstract void Rotate(float turnSpeed);

    //sprint function
    public abstract void Sprint(Vector3 direction, float speed);
}
