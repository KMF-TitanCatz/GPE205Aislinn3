using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   
    public static GameManager instance;

    // Awake is called when the object is first created - before even Start can run!
    private void Awake()
    {
        //if the instance does not exist yey
        if (instance == null)
        {
            //this is the instance
            instance = this;
        }
        else
        {
            //otherwise there is already an instance. Destroy this instance
            Destroy(gameObject);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
