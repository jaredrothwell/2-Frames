using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sounds : MonoBehaviour
{
    public float timer = 1.0f;
    public float currentTimer = 0.0f;
    public List<AudioClip> sfx;


    // Update is called once per frame
    void Update()
    {
        currentTimer += Time.deltaTime;
        if (currentTimer >= timer)
        {
            currentTimer = 0.0f;
            AudioSource audio = GetComponent<AudioSource>();
            int i = Random.Range(0, sfx.Count);
            audio.clip = sfx[i];
            audio.Play();
        }
    }
}
