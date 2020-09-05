using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levitation : MonoBehaviour
{
    public float timer = 1.0f;
    public float currentTimer = 0.0f;
    public float speed = 0.1f;
    public bool isFacingRight = true;
    public Transform t;
    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        t.position += new Vector3(0, speed * Time.deltaTime, 0);

        if (Input.GetKey("a"))
        {
            if (isFacingRight)
            {
                flip();
                isFacingRight = false;
            }
        }
        if (Input.GetKey("d"))
        {
            if (!isFacingRight)
            {
                flip();
                isFacingRight = true;
            }
        }
    }

    private void FixedUpdate()
    {
        currentTimer += Time.deltaTime;
        if(currentTimer >= timer)
        {
            currentTimer = 0.0f;
            speed = -speed;
        }
    }
    void flip()
    {
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}

