using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class electric : MonoBehaviour
{
    public List<AudioClip> sfxElectric;
    public List<AudioClip> sfxHit;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();
        int i = Random.Range(0, sfxHit.Count);
        audio.clip = sfxElectric[i];
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
            int i = Random.Range(0, sfxHit.Count);
            Transform cam = GameObject.Find("Main Camera").transform;
            AudioSource.PlayClipAtPoint(sfxHit[i], cam.position);
            collision.GetComponent<Movement>().damage(1);
        }

    }
}
