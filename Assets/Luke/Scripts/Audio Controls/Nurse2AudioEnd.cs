using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nurse2AudioEnd : MonoBehaviour
{
    AudioSource myAudio;

    public GameObject Nurse2;
    public GameObject Doctor8;

    public Animator Doctor2Animator;
    public Animator Nurse2Animator;

    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        Invoke("audioFinished", myAudio.clip.length);
    }

    void audioFinished()
    {
        Debug.Log("Nurse2 Audio Finished");
        Doctor2Animator.Play("Turn1802");
        Nurse2Animator.Play("Turn180");
        Doctor8.SetActive(true);
        Nurse2.SetActive(false);

    }
}
