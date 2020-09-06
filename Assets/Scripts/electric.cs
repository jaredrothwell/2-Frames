using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class electric : MonoBehaviour
{
    public AudioClip sfxElectric;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = sfxElectric;
        audio.Play();
    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Player" && collision.tag != "proj" && collision.tag != "Enemy")
            Destroy(gameObject);
        else if (collision.tag == "Player")
        {
            Destroy(gameObject);
            collision.GetComponent<Movement>().damage(1);
        }

    }
}
