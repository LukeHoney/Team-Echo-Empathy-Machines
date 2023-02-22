using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daughter2AudioEnd : MonoBehaviour
{
    AudioSource myAudio;

    public GameObject Daughter2;
    public GameObject Doctor3;

    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        Invoke("audioFinished", myAudio.clip.length);
    }

    void audioFinished()
    {
        Debug.Log("Daughter1 Audio Finished");
        Doctor3.SetActive(true);
        Daughter2.SetActive(false);
    }
}
