using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    public Button QuitButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = QuitButton.GetComponent<Button>();
        btn.onClick.AddListener(doExitGame);
    }
    void doExitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }
}
