using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightAnswer : MonoBehaviour
{
    public Button correctButton;

    public GameObject currentPanel;
    public GameObject newPanel;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = correctButton.GetComponent<Button>();
        btn.onClick.AddListener(Loadcorrect);
    }

    public void Loadcorrect()
    {
        newPanel.SetActive(true);
        currentPanel.SetActive(false);
    }
}
