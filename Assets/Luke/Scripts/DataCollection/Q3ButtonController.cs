using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Q3ButtonController : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;


    void OnEnable()
    {
        //Register Button Events
        button1.onClick.AddListener(() => buttonCallBack(button1));
        button2.onClick.AddListener(() => buttonCallBack(button2));
        button3.onClick.AddListener(() => buttonCallBack(button3));
        button4.onClick.AddListener(() => buttonCallBack(button4));
        button5.onClick.AddListener(() => buttonCallBack(button5));
    }
    private void buttonCallBack(Button buttonPressed)
    {
        if (buttonPressed == button1)
        {
            //Your code for button 1
            Debug.Log("Clicked: Experience " + button1.name);
        }

        if (buttonPressed == button2)
        {
            //Your code for button 2
            Debug.Log("Clicked: Experience " + button2.name);
        }

        if (buttonPressed == button3)
        {
            //Your code for button 3
            Debug.Log("Clicked: Experience " + button3.name);
        }


        if (buttonPressed == button4)
        {
            //Your code for button 4
            Debug.Log("Clicked: Experience " + button4.name);
        }

        if (buttonPressed == button5)
        {
            //Your code for button 5
            Debug.Log("Clicked: Experience " + button5.name);
        }
    }
}
