using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyFishAttack : MonoBehaviour
{
    public float timer = 0.54f;
    public float current = 0.0f;
    public GameObject electric;
    public float spd = 2f;

    private GameObject Player;

    private void Start()
    {
        Player = GameObject.Find("Player");
    }
    // Update is called once per frame
    void Update()
    {
        current += Time.deltaTime;
        if (current >= timer)
        {
            current = 0.0f;
            GameObject elec = Instantiate(electric);
            elec.transform.position = transform.position;
            Vector2 direction = (Vector2)Player.transform.position - (Vector2)elec.transform.position;
            direction.Normalize();
            Rigidbody2D rb = elec.GetComponent<Rigidbody2D>();
            rb.velocity = direction * spd;
        }
    }
}
