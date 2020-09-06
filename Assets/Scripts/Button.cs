using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public AudioClip Play;
    public float timer = 1.0f;
    public float currentTimer = 0.0f;
    public bool start = false;
    public void loadGame()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = Play;
        audio.Play();
        start = true;
    }
    public void quit()
    {
        Application.Quit();
    }

    private void Update()
    {
        if (start)
        {
            currentTimer += Time.deltaTime;
            if (currentTimer >= timer)
            {
                SceneManager.LoadScene("Game", LoadSceneMode.Single);
            }
        }
    }
}
