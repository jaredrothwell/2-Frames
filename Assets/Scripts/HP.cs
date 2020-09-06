using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{
    public List<GameObject> hearts;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDamge()
    {
        Destroy(hearts[0]);
        hearts.RemoveAt(0);
        if(hearts.Count == 0)
        {
            SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
        }
    }
}
