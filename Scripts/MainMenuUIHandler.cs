using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenuUIHandler : MonoBehaviour
{
    public Button PlayGameButton;
    public Button InstructionGameButton;
    public Button QuitGameButton;
    public Toggle MusicToggle;
    



    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void InstructionScene()
    {
        SceneManager.LoadScene("InstructionMenu");
    }
    public void ValidateChoices()
    {
        // check music toggle   
        if (MusicToggle.enabled)
        {
            PlayerPrefs.SetInt("MusicOn", 1);
        }
        else
        {
            PlayerPrefs.SetInt("MusicOff", 0);
        }
    }
}
