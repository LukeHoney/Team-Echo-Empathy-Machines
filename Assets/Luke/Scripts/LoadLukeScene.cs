using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadLukeScene : MonoBehaviour
{
    public Button mainButton;    
    // Start is called before the first frame update
    void Start()
    {
        Button btn = mainButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadLuke);
    }

    public void LoadLuke()
    {
        SceneManager.LoadScene("Luke");
    }
}
