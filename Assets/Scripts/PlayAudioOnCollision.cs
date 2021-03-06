using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnCollision : MonoBehaviour
{

    public AudioSource audio;
    public AudioSource audioAnimal;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        //if object has tag "Player" play audio
        if (other.CompareTag("Player") && !audio.isPlaying)
            //play sound
            audio.Play();
            audioAnimal.Play();
    }
}
