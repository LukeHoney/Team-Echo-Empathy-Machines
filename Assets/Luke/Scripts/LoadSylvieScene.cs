using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSylvieScene : MonoBehaviour
{
    public Button sylvieButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = sylvieButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadSylvie);
    }

    public void LoadSylvie()
    {
        SceneManager.LoadScene("SylvieStory");
    }
}
