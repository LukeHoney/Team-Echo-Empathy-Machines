using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doctor4AudioEnd : MonoBehaviour
{
    AudioSource myAudio;
    public GameObject question2panel;
    public GameObject Doctor4;

    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        Invoke("audioFinished", myAudio.clip.length);
    }

    void audioFinished()
    {
        Debug.Log("Doctor4 Audio Finished");
        question2panel.SetActive(true);
        Doctor4.SetActive(false);
    }
}
