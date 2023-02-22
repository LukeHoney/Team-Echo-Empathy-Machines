using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSusanScene : MonoBehaviour
{
    public Button susanButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = susanButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadSusan);
    }

    public void LoadSusan()
    {
        SceneManager.LoadScene("SusanStory");
    }
}
