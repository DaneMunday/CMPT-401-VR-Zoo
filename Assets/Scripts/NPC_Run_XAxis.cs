using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Run_XAxis : MonoBehaviour
{

    int stepCount;
    int direction;

    // Start is called before the first frame update
    void Start()
    {

        stepCount = 0;

        direction = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //check if step count is exceeded
        if (stepCount < 165)
        {
            //increment z position
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + direction);
            stepCount += 1;
        }

        else
        {
            stepCount = 0;

            //turn 180 degrees
            transform.Rotate(0, 180, 0);
            direction = direction * -1;
        }
    }
}
