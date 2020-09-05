using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour
{
    public Transform pivot;
    public float spd = 10f;
    public bool isShooting = false;

    public AudioClip sfxFire;
    public AudioClip sfxFireThrown;

    public void thrown()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = sfxFireThrown;
        audio.Play();
    }
    private void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = sfxFire;
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isShooting)
        {
            transform.RotateAround(pivot.position, Vector3.forward, 20 * Time.deltaTime * spd);
            transform.rotation = Quaternion.Euler(Vector3.forward);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Player")
            Destroy(gameObject);
    }

}
