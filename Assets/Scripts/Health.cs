using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    //var
    public float currentHealth;
    public float maxHealth;

    // Start is called before the first frame update
    void Start()
    {
        //set health to max
        currentHealth = maxHealth;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //function to subtract health when damage taken
    public void TakeDamage(float amount, Pawn source)
    {
        currentHealth = currentHealth - amount;
        Debug.Log(source.name + " did " + amount + " damage to " + gameObject.name);
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        if (currentHealth <= 0)
        {
            Die(source);
        }
    }

    public void Heal(float amount, Pawn source)
    {
        currentHealth = currentHealth + amount;
        Debug.Log(source.name + " healed " + amount + " health to " + gameObject.name);
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
    }

    public void Die(Pawn source)
    {
        Destroy(gameObject);
    }

}
