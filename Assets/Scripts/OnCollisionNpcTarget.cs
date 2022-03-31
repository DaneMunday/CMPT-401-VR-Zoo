using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach to target
public class OnCollisionNpcTarget : MonoBehaviour
{
    public GameObject character;

    //script reference
    private PlayerMovementBetweenMarkers script;

    // Start is called before the first frame update
    void Start()
    {
        script = character.GetComponent<PlayerMovementBetweenMarkers>();
    }



    //when target reached
    private void OnTriggerEnter(Collider other)
    {
        //if object has tag "Player"
        if (other.CompareTag("NPC"))
        {
            //if collision detected, increment targetSelector by 1
            if (script.targetID < 5)
            {
                script.targetID += 1;
            }

            else
            {
                script.targetID = 1;
            }
        }
    }
}
