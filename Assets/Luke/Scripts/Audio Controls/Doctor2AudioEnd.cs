using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doctor2AudioEnd : MonoBehaviour
{
    AudioSource myAudio;

    public GameObject Daughter2;
    public GameObject Doctor2;

    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        Invoke("audioFinished", myAudio.clip.length);
    }

    void audioFinished()
    {
        Debug.Log("Doctor2 Audio Finished");
        
        Daughter2.SetActive(true);
        Doctor2.SetActive(false);
    }
}
