using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public float timer = 0.54f;
    public float current = 0.0f;
    public int fireballmax = 8;
    public int currentNum = 0;
    public GameObject fireball;
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
            if (currentNum < fireballmax)
            {
                GameObject fire = Instantiate(fireball);
                fire.transform.position = transform.position + new Vector3(0, 0.25f, 0);
                fire.transform.SetParent(transform);
                fire.GetComponent<fireball>().pivot = transform;
                currentNum++;
            }
        }
    }
}
