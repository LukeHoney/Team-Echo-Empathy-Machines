using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartDoctor1 : MonoBehaviour
{
    public Button startButton;

    public GameObject Doctor1;
    public GameObject welcomePanel;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = startButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadDoctor1);
    }

    public void LoadDoctor1()
    {
        Doctor1.SetActive(true);
        welcomePanel.SetActive(false);
    }
}
