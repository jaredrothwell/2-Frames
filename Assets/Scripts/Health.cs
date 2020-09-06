using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Sprite spr1;
    public Sprite spr2;
    public float timer = 0.54f;
    public float current = 0.0f;

    private Image sr;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<Image>();
        sr.sprite = spr1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        current += Time.deltaTime;
        if (current >= timer)
        {
            current = 0.0f;
            if (sr.sprite == spr1)
                sr.sprite = spr2;
            else
                sr.sprite = spr1;
        }
    }
}
