using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float timer = 1.0f;
    public float currentTimer = 0.0f;
    public GameObject enemy;
    public List<Transform> tList;

    // Update is called once per frame
    void Update()
    {
        currentTimer += Time.deltaTime;
        if (currentTimer >= timer)
        {
            currentTimer = 0.0f;
            GameObject e = Instantiate(enemy);
            int i = Random.Range(0, tList.Count);
            e.transform.position = tList[i].position;
        }

    }
}
