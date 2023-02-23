using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doctor5AudioEnd : MonoBehaviour
{
    AudioSource myAudio;

    public GameObject question3panel;
    public GameObject Doctor5;

    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        Invoke("audioFinished", myAudio.clip.length);
    }

    void audioFinished()
    {
        Debug.Log("Doctor4 Audio Finished");
        question3panel.SetActive(true);
        Doctor5.SetActive(false);
    }
}
