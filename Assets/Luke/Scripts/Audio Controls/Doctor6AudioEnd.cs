using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doctor6AudioEnd : MonoBehaviour
{
    AudioSource myAudio;

    public GameObject Nurse1;
    public GameObject Doctor6;
    public GameObject FemaleDoctor;

    public Animator NurseAnimator;

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
        FemaleDoctor.SetActive(false);
        NurseAnimator.Play("Turn180");
        Doctor6.SetActive(false);
        
    }
}
