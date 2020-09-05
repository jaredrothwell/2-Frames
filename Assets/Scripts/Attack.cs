using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public float timer = 0.54f;
    public float current = 0.0f;
    public int fireballmax = 8;
    public int currentNum = 0;
    public GameObject fireball;
    public float spd = 3f;
    private List<GameObject> fList = new List<GameObject>();
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && fList.Count > 0)
        {
            GameObject fire = fList[0];
            fList.RemoveAt(0);
            Vector2 cursorInWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = cursorInWorldPos - (Vector2)fire.transform.position;
            direction.Normalize();
            Rigidbody2D rb = fire.GetComponent<Rigidbody2D>();
            rb.simulated = true;
            rb.velocity = direction * spd;
            fireball f = fire.GetComponent<fireball>();
            f.transform.parent = null;
            f.isShooting = true;
            currentNum--;
        }
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
                fire.GetComponent<Rigidbody2D>().simulated = false;
                fire.transform.position = transform.position + new Vector3(0, 0.25f, 0);
                fire.transform.SetParent(transform);
                fire.GetComponent<fireball>().pivot = transform;
                currentNum++;
                fList.Add(fire);
            }
        }
    }
}
