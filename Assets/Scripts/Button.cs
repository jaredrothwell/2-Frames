using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void loadGame()
    {
        Debug.Log("Clicked Play");
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }
    public void quit()
    {
        Application.Quit();
    }
}
