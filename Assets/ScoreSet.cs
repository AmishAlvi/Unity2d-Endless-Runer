using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreSet : MonoBehaviour
{
    private Text Score;
    // Start is called before the first frame update
    void Start()
    {
        Score = gameObject.GetComponent<Text>();
        Score.text = PlayerPrefs.GetInt("Score") + " Cars"; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("MainScene");
    }
}
