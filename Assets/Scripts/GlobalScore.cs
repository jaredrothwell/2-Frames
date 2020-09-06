using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScore : MonoBehaviour
{
    public static GlobalScore Instance;

    public int HighScore = 0;
    public int Score = 0;
    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        if(Score > HighScore)
        {
            HighScore = Score;
        }
    }
}

