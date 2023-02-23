using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daughter3AudioEnd : MonoBehaviour
{
    AudioSource myAudio;

    public GameObject Daughter3;
    public GameObject Doctor4;

    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        Invoke("audioFinished", myAudio.clip.length);
    }

    void audioFinished()
    {
        Debug.Log("Daughter3 Audio Finished");
        Doctor4.SetActive(true);
        Daughter3.SetActive(false);
    }
}
