using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBullet : MonoBehaviour
{
    public GameObject prefab;
    public Transform firepointTransform;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newObject = Instantiate(prefab, transform.position, transform.rotation) as GameObject;
        Debug.Log(newObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //get rigidbody component
    Rigidbody rb = GetComponent<Rigidbody>();
    //if it has one
    if (rb != null)
        {
            //add force to move it forward
            rb.AddForce(firepointTransform.forward * fireForce);
        }

}
