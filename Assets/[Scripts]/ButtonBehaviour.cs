using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour
{
    public void OnStartButtonPressed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OnNextButtonPressed()
    {
        SceneManager.LoadScene("End");
    }

    public void OnBackButtonPressed()
    {
        SceneManager.LoadScene("Start");
    }
}
