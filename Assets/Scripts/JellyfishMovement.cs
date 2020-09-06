using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyfishMovement : MonoBehaviour
{
    public float timer = 0.5f;
    public float currentTimer = 0.0f;
    public float spd = 1.0f;

    private Rigidbody2D rb;
    private Vector2 v =  new Vector2(0f, 0f);
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        currentTimer += Time.deltaTime;
        if (currentTimer >= timer)
        {
            currentTimer = 0.0f;
            timer = Random.Range(1.0f, 3.0f);
            v = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
        }
        rb.velocity = v * spd;
    }
}
