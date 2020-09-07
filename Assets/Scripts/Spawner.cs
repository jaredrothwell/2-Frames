using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float timerMax = 4.0f;
    public float timerMin = 2.0f;
    public float timer = 3.0f;
    public float currentTimer = 0.0f;
    public GameObject enemy;
    public List<Transform> tList;
    public int numOfEnemies = 3;
    public float timerEnemies = 20f;
    public float currentTimer2 = 0.0f;
    // Update is called once per frame
    void Update()
    {
        currentTimer += Time.deltaTime;
        if (currentTimer >= timer)
        {
            timer = Random.Range(timerMin, timerMax);
            currentTimer = 0.0f;
            int y = Random.Range(1, numOfEnemies);
            while (y != 0)
            {
                GameObject e = Instantiate(enemy);
                int i = Random.Range(0, tList.Count);
                e.transform.position = tList[i].position;
                y--;
            }
            timerMax -= 0.01f;
            timerMin -= 0.01f;
            if(timerMin < .54f)
            {
                timerMin = .54f;
                timerMax = 1.08f;
            }
        }
        currentTimer2 += Time.deltaTime;
        if(currentTimer2 >= timerEnemies)
        {
            currentTimer2 = 0.0f;
            numOfEnemies++;
            timerEnemies *= 2;
        }

    }
}
