using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour
{
    public Transform pivot;
    public float spd = 10f;
    public bool isShooting = false;

    public List<AudioClip> sfxFire;
    public List<AudioClip> sfxFireThrown;
    public AudioClip sfxEnemyDeath;

    public void thrown()
    {
        //AudioSource audio = GetComponent<AudioSource>();
        //audio.clip = sfxFireThrown;
        //audio.Play();
        int i = Random.Range(0, sfxFireThrown.Count);
        Transform cam = GameObject.Find("Main Camera").transform;
        AudioSource.PlayClipAtPoint(sfxFireThrown[i], cam.position);
    }
    private void Start()
    {
        int i = Random.Range(0, sfxFire.Count);
        Transform cam = GameObject.Find("Main Camera").transform;
        AudioSource.PlayClipAtPoint(sfxFire[i], cam.position);
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
        if(collision.tag == "Enemy")
        {
            Transform cam = GameObject.Find("Main Camera").transform;
            AudioSource.PlayClipAtPoint(sfxEnemyDeath, cam.position);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if (collision.tag != "Player" && collision.tag != "proj")
            Destroy(gameObject);
        
    }

}
