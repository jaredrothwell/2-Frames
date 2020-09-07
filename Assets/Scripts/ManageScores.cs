using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageScores : MonoBehaviour
{
    public Text HighScore;
    public Text Score;
    public Text Dead;
    // Start is called before the first frame update
    void Start()
    {
        GameObject globalScore = GameObject.Find("GlobalScore");
        if(globalScore.GetComponent<GlobalScore>().HighScore != 0)
        {
            HighScore.text = "HighScore:" + globalScore.GetComponent<GlobalScore>().HighScore;
            Score.text = "Score:" + globalScore.GetComponent<GlobalScore>().Score;
            Dead.text = "You Died";
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }
        else
        {
            HighScore.text = "";
            Score.text = "";
            Dead.text = "";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
