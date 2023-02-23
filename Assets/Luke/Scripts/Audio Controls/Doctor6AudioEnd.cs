using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doctor6AudioEnd : MonoBehaviour
{
    AudioSource myAudio;

    public GameObject Nurse1;
    public GameObject Doctor6;

    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        Invoke("audioFinished", myAudio.clip.length);
    }

    void audioFinished()
    {
        Debug.Log("Doctor6 Audio Finished");

        Nurse1.SetActive(true);
        Doctor6.SetActive(false);
    }
}
