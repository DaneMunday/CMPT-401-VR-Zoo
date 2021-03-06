using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Walk_XAxis : MonoBehaviour
{

    int stepCount;
    int direction;
    private bool shouldGo;

    // Start is called before the first frame update
    void Start()
    {

        stepCount = 0;

        direction = 1;
        shouldGo = true;
    }

    // Update is called once per frame
    void Update()
    {
        //check if step count is exceeded
        if (stepCount < 40 && shouldGo == true)
        {
            //increment z position
            transform.position = new Vector3(transform.position.x + direction, transform.position.y, transform.position.z);
            stepCount += 1;

            shouldGo = false;
        }

        else
        {
            shouldGo = true;

            if (stepCount >= 40)
            {
                stepCount = 0;

                //turn 180 degrees
                transform.Rotate(0, 180, 0);
                direction = direction * -1;
            }
            
        }
    }
}
