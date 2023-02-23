using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nurse1AudioEnd : MonoBehaviour
{
    AudioSource myAudio;

    public GameObject Nurse1;
    public GameObject Doctor7;

    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        Invoke("audioFinished", myAudio.clip.length);
    }

    void audioFinished()
    {
        Debug.Log("Nurse1 Audio Finished");
        Doctor7.SetActive(true);
        Nurse1.SetActive(false);
        
    }
}
