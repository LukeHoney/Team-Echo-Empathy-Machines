using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question4 : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;

    public GameObject currentPanel;
    public GameObject score0Panel;
    public GameObject score1Panel;
    public GameObject score2Panel;
    public GameObject score3Panel;
    public GameObject score4Panel;

    public int correctAnswers;

    void Start()
    {
        correctAnswers = 0;
    }


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
            correctAnswers = correctAnswers + 1;
            LoadScore();
        }

        if (buttonPressed == button2)
        {
            //Your code for button 2
            Debug.Log("Clicked: " + button2.name);
            LoadScore();
        }

        if (buttonPressed == button3)
        {
            //Your code for button 3
            Debug.Log("Clicked: " + button3.name);
            LoadScore();
        }


        if (buttonPressed == button4)
        {
            //Your code for button 4
            Debug.Log("Clicked: " + button4.name);
            LoadScore();
        }
    }
    public void LoadScore()
    {
        if (correctAnswers == 0)
        {
            Debug.Log("0 out of 4");
            score1Panel.SetActive(true);
            currentPanel.SetActive(false);
        }

        if (correctAnswers == 1)
        {
            Debug.Log("1 out of 4");
            score1Panel.SetActive(true);
            currentPanel.SetActive(false);
        }

        if (correctAnswers == 2)
        {
            Debug.Log("2 out of 4");
            score2Panel.SetActive(true);
            currentPanel.SetActive(false);
        }

        if (correctAnswers == 3)
        {
            Debug.Log("3 out of 4");
            score3Panel.SetActive(true);
            currentPanel.SetActive(false);
        }

        if (correctAnswers == 4)
        {
            Debug.Log("4 out of 4");
            score4Panel.SetActive(true);
            currentPanel.SetActive(false);
        }
    }
}
