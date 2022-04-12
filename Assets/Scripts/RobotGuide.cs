using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotGuide : MonoBehaviour
{
    public GameObject player;
    public AudioSource speech;
    private Vector3 targetPosition;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Playaudio());
    }

    IEnumerator Playaudio(){
        yield return new WaitForSeconds(10);
        speech.Play();
    }

    // Update is called once per frame
    void Update()
    {

        //update player position
        targetPosition = player.transform.position;

        targetPosition.x -= 15;
        targetPosition.z -= 10;

        //move towards player
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * 12.0f);
    }
}
