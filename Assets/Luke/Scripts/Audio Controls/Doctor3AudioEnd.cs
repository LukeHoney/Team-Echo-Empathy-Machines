using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doctor3AudioEnd : MonoBehaviour
{
    AudioSource myAudio;

    public GameObject Doctor3;
    public GameObject Daughter3;

    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        Invoke("audioFinished", myAudio.clip.length);
    }

    void audioFinished()
    {
        Debug.Log("Doctor3 Audio Finished");
        Daughter3.SetActive(true);
        Doctor3.SetActive(false);
    }
}
