using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainMovement : MonoBehaviour
{
    private int distanceTravelled;
    //int 1-4 to determien what segment train is on
    private int trackSegment;

    public bool isMoving = true;

    // Start is called before the first frame update
    void Start()
    {
        distanceTravelled = 0;
        trackSegment = 1;

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(isMoving);
        //traverse segment 1
        if (distanceTravelled < 317)
        {
            //moveAcrossSegment 1 (+x)
            transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
            distanceTravelled += 1;
        }

        //traverse segment 2
        else if (distanceTravelled >= 317 && distanceTravelled < 423)
        {
            //check if still need to turn
            if (trackSegment == 1)
            {
                //turn 90 degrees
                transform.Rotate(0, -90, 0);
                trackSegment += 1;
            }

            //moveAcrossSegment 2 (+x)
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1);
            distanceTravelled += 1;
        }

        //traverse segment 3
        else if (distanceTravelled >= 423 && distanceTravelled < 740)
        {
            //check if still need to turn
            if (trackSegment == 2)
            {
                //turn 90 degrees
                transform.Rotate(0, -90, 0);
                trackSegment += 1;
            }

            //moveAcrossSegment 3 (+x)
            transform.position = new Vector3(transform.position.x -1, transform.position.y, transform.position.z);
            distanceTravelled += 1;
        }

        //traverse segment 4
        else if (distanceTravelled >= 740 && distanceTravelled < 846)
        {
            //check if still need to turn
            if (trackSegment == 3)
            {
                //turn 90 degrees
                transform.Rotate(0, -90, 0);
                trackSegment += 1;
            }

            //moveAcrossSegment 4 (+x)
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1);
            distanceTravelled += 1;
        }

        //rotate for boarding
        else if (distanceTravelled >= 846)
        {
            if (trackSegment == 4)
            {
                //turn 90 degrees
                transform.Rotate(0, -90, 0);

                trackSegment = 1;

                //call boarding wait function
                StartCoroutine(WaitForBoarding());
            }
        }
    }

    private IEnumerator WaitForBoarding()
    {
        isMoving = false;

        yield return new WaitForSeconds(10.0f);
        //reset distance travelled
        distanceTravelled = 0;

        isMoving = true;
    }
}
