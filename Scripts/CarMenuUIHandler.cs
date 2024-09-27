using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarMenuUIHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Music" + PlayerPrefs.GetInt("MusicOn"));
    }

    public void SelectCar()
    {
        SceneManager.LoadScene(2); 
    }
    public void GoBackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
