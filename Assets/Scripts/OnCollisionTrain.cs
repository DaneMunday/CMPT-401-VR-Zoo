using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionTrain : MonoBehaviour
{

    public GameObject fpsController;
    public GameObject trainCabin;
    public GameObject dismountPosition;

    public TrainMovement script;
    private bool isMoving;

    private bool playerInTrain;

    // Start is called before the first frame update
    void Start()
    {
        isMoving = script.isMoving;
        playerInTrain = false;
    }

    // Update is called once per frame
    void Update()
    {
        //update bool
        isMoving = script.isMoving;

        //keep player in train if moving
        if (isMoving && playerInTrain)
        {
            fpsController.transform.position = new Vector3(trainCabin.transform.position.x, trainCabin.transform.position.y, trainCabin.transform.position.z);
        }

        //dismount when stopped
        else if (!isMoving && playerInTrain)
        {
            playerInTrain = false;
            Dismount();
        }
    }

    //board train
    private void OnTriggerEnter(Collider other)
    {
        //if object has tag "Player"
        if (other.CompareTag("Player"))
        {
            playerInTrain = true;
            //set player position to position when riding train
            fpsController.transform.position = new Vector3(trainCabin.transform.position.x, trainCabin.transform.position.y, trainCabin.transform.position.z);
        }
    }

    //dismount
    private void Dismount()
    {
        //do once
        fpsController.transform.position = dismountPosition.transform.position;
    }
}
