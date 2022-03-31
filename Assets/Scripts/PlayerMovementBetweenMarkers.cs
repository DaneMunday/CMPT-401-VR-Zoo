using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach to player (FPS controller)
public class PlayerMovementBetweenMarkers : MonoBehaviour
{
    //possible targets
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;

    //current target
    private GameObject target;

    //determines target
    public int targetID;

    // Start is called before the first frame update
    void Start()
    {
        target = one;
        targetID = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //choose and update current target
        ChooseTarget();

        //move self towards target at specified speed
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * 12.0f);
    }

    //choose target
    private void ChooseTarget()
    {
        if (targetID == 1)
        {
            target = one;
        }

        else if (targetID == 2)
        {
            target = two;
        }

        else if (targetID == 3)
        {
            target = three;
        }

        else if (targetID == 4)
        {
            target = four;
        }

        else if (targetID == 5)
        {
            target = five;
        }
    }
}
