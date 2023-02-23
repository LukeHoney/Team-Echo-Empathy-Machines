using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doctor8AudioEnd : MonoBehaviour
{
    AudioSource myAudio;
    
    public GameObject Doctor8;

    [SerializeField] Question4 Question4;

    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        Invoke("audioFinished", myAudio.clip.length);
    }

    void audioFinished()
    {
        Debug.Log("Doctor8 Audio Finished");
        Question4.LoadScore();
        Doctor8.SetActive(false);
    }
}
