using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainScreen : MonoBehaviour
{
    public InputField nameInput;
    public Text playerNameText;
    public Button playButton;

    private string playerName;

    private void Start()
    {
        playButton.onClick.AddListener(OnPlayButtonClicked);
    }

    public void OnNameEntered()
    {
        playerName = nameInput.text;
        playerNameText.text = playerName;
    }

    public void OnPlayButtonClicked()
    {
        SceneManager.LoadScene(1);
        if (!string.IsNullOrEmpty(playerName))
        {
            //GameManager.Instance.StartGame(playerName);
            // Or, if the game manager is not a singleton, obtain its reference through other means
            
        }
    }
}


