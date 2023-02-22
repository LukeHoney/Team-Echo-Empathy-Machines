using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doctor1AudioEnd : MonoBehaviour
{
    AudioSource myAudio;
    public GameObject question1panel;

    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        Invoke("audioFinished", myAudio.clip.length);
    }

    void audioFinished()
    {
        Debug.Log("Doctor1 Audio Finished");
        question1panel.SetActive(true);
    }

}

