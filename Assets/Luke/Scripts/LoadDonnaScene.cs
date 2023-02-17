using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadDonnaScene : MonoBehaviour
{
    public Button donnaButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = donnaButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadDonna);
    }

    public void LoadDonna()
    {
        SceneManager.LoadScene("DonnaStory");
    }
}
