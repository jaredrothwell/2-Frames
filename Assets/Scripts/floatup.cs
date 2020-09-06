using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatup : MonoBehaviour
{
    public float timer = 1.0f;
    public float currentTimer = 0.0f;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed * Time.deltaTime, speed * Time.deltaTime, 0);
        currentTimer += Time.deltaTime;
        if (currentTimer >= timer)
        {
            Destroy(gameObject);
        }
    }
}
