using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndAudioOnCollisionExit : MonoBehaviour
{
    public GameObject signWithCollider;
    private AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = signWithCollider.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerExit(Collider other)
    {
        //if object has tag "Player" play audio
        if (other.CompareTag("Player"))
            //play sound
            audio.Stop();
    }
}
