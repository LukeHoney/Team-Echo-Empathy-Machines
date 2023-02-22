using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daughter1AudioEnd : MonoBehaviour
{
    AudioSource myAudio;

    public GameObject Daughter1;
    public GameObject Doctor2;

    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        Invoke("audioFinished", myAudio.clip.length);
    }

    void audioFinished()
    {
        Debug.Log("Daughter1 Audio Finished");
        Doctor2.SetActive(true);
        Daughter1.SetActive(false);
    }
}
