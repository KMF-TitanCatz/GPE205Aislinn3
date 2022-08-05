using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnHit : MonoBehaviour
{
    public float damageDone;
    public Pawn owner;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        //get health component from the game object that has collider we are overlaping
        Health otherHealth = other.gameObject.GetComponent<Health>();
        //only damage if it has a health component
        if (otherHealth != null)
        {
            //do damage
            otherHealth.TakeDamage(damageDone, owner);
        }

        //destroy ourselves, wether we did damage or not
        Destroy(gameObject);
    }
}
