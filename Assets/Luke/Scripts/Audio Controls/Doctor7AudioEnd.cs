using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doctor7AudioEnd : MonoBehaviour
{
    AudioSource myAudio;

    public GameObject question4panel;
    public GameObject Doctor7;

    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        Invoke("audioFinished", myAudio.clip.length);
    }

    void audioFinished()
    {
        Debug.Log("Doctor7 Audio Finished");

        question4panel.SetActive(true);
        Doctor7.SetActive(false);
    }
}
