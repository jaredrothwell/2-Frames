using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float timer = 0.1f;
    public float currentTimer = 0.0f;
    public float timer2 = 1.0f;
    public float currentTimer2 = 0.0f;
    public int score = 0;

    // Update is called once per frame
    void Update()
    {
        currentTimer += Time.deltaTime;
        if (currentTimer >= timer)
        {
            currentTimer = 0.0f;
            Text c = GetComponent<Text>();
            c.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            c.text = "Score:" + score;
        }
        currentTimer2 += Time.deltaTime;
        if (currentTimer2 >= timer2)
        {
            score += 10;
            currentTimer2 = 0.0f;
        }
        GameObject globalScore = GameObject.Find("GlobalScore");
        if(globalScore != null)
            globalScore.GetComponent<GlobalScore>().Score = score;
    }

    public void addScore(int x)
    {
        score += x;
        Text c = GetComponent<Text>();
        c.text = "Score:" + score;

    }
}
