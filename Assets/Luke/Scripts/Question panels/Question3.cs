using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question3 : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;

    public GameObject currentPanel;
    public GameObject newPanel;

    public GameObject Doctor6;

    [SerializeField] Question4 Question4;

    public Animator DoctorAnimator;

    void OnEnable()
    {
        //Register Button Events
        button1.onClick.AddListener(() => buttonCallBack(button1));
        button2.onClick.AddListener(() => buttonCallBack(button2));
        button3.onClick.AddListener(() => buttonCallBack(button3));
        button4.onClick.AddListener(() => buttonCallBack(button4));
    }
    private void buttonCallBack(Button buttonPressed)
    {
        if (buttonPressed == button1)
        {
            //Your code for button 1
            Debug.Log("Clicked: " + button1.name);
            Question4.correctAnswers = Question4.correctAnswers + 1;
            StartDoctor6();
            //newPanel.SetActive(true);
            //currentPanel.SetActive(false);
        }

        if (buttonPressed == button2)
        {
            //Your code for button 2
            Debug.Log("Clicked: " + button2.name);
            StartDoctor6();
            //newPanel.SetActive(true);
            //currentPanel.SetActive(false);
        }

        if (buttonPressed == button3)
        {
            //Your code for button 3
            Debug.Log("Clicked: " + button3.name);
            StartDoctor6();
            //newPanel.SetActive(true);
            //currentPanel.SetActive(false);
        }


        if (buttonPressed == button4)
        {
            //Your code for button 4
            Debug.Log("Clicked: " + button4.name);
            StartDoctor6();
            //newPanel.SetActive(true);
            //currentPanel.SetActive(false);
        }
    }
    void StartDoctor6()
    {
        Doctor6.SetActive(true);
        DoctorAnimator.Play("Turn180");
        currentPanel.SetActive(false);
    }
}
