using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class GameManager : MonoBehaviour
{
   //var
    public static GameManager instance;
    public Transform playerSpawnTransform;

    //List of player(s)
    public List<PlayerController> players;


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
        //TEMP CODE spawns player
        SpawnPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnPlayer()
    {
        //Spawn the player controller (0,0,0) no rotation
        GameObject newPlayerObj = Instantiate(playerControllerPrefab, Vector3.zero, Quaternion.identity) as GameObject;

        //Spawn the pawn and connect it to the controller
        GameObject newpawnObj = Instantiate(tankPawnPrefab, playerSpawnTransform.position, playerSpawnTransform.rotation) as GameObject;

        //Get the player controller and pawn components
        Controller newController = newPlayerObj.GetComponent<Controller>();
        Pawn newPawn = newpawnObj.GetComponent<Pawn>();

        //Hook everyting up
        newController.pawn = newPawn;
    }

    //Prefabs
    public GameObject playerControllerPrefab;
    public GameObject tankPawnPrefab;
}
