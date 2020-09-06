using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{
    public List<GameObject> hearts;
    public AudioSource audioSource1;
    public AudioSource audioSource2;
    public AudioSource audioSource3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDamge()
    {
        Destroy(hearts[0]);
        hearts.RemoveAt(0);
        if (hearts.Count == 2)
        {
            StartCoroutine(StartFade(audioSource1, 1.0f, 0.0f));
            StartCoroutine(StartFade(audioSource2, 1.0f, 1.0f));
        }
        else
        {
            StartCoroutine(StartFade(audioSource2, 1.0f, 0.0f));
            StartCoroutine(StartFade(audioSource3, 1.0f, 1.0f));
        }
        if (hearts.Count == 0)
        {
            SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
        }
    }
    public static IEnumerator StartFade(AudioSource audioSource, float duration, float targetVolume)
    {
        float currentTime = 0;
        float start = audioSource.volume;

        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(start, targetVolume, currentTime / duration);
            yield return null;
        }
        yield break;
    }
}
