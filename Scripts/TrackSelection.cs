using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TrackSelection : MonoBehaviour
{
    public Button SnowTrackSelectButton;
    public Button DirtTrackSelectButton;
    public Button BackToCarMenu;


    public void SelectSnowTrack()
    {
        SceneManager.LoadScene(2);
    }
    public void SelectDirtTrack()
    {
        SceneManager.LoadScene(3);
    }
    public void BackToCarSelectionMenu()
    {
        SceneManager.LoadScene(0);
    }
}
