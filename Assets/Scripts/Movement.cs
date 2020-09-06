using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;

    public int health = 3;
    public float spd = 10.0f;
    public GameObject hp;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = 0;
        float vertical = 0;
        if (Input.GetKey("w"))
        {
            vertical += 1;
        }
        if (Input.GetKey("a"))
        {
            horizontal -= 1;
        }
        if (Input.GetKey("s"))
        {
            vertical -= 1;
        }
        if (Input.GetKey("d"))
        {
            horizontal += 1;
        }
        Vector2 movement = new Vector2(horizontal, vertical);

        rb.velocity = movement.normalized * spd;
    }

    public void damage(int dmg)
    {
        health -= dmg;
        hp.GetComponent<HP>().takeDamge();
    }
}
