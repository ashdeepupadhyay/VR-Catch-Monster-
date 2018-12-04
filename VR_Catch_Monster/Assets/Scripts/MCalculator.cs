using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MCalculator : MonoBehaviour {

    CalculateScore calscore;
    public TextMesh totalMonster;
    public float timeRemaining;
    public TextMesh timerText;

    MusicManager m;
    // Use this for initialization
    void Start () {
        m = FindObjectOfType<MusicManager>();
        calscore = FindObjectOfType<CalculateScore>();
        totalMonster.text = calscore.score.ToString();  
        
    }

    // Update is called once per frame
    void Update () {
        //DisplayScore();
        timeRemaining -=  Time.deltaTime;
        timerText.text = Mathf.Floor(timeRemaining).ToString();
        if(timeRemaining<1)
        {
            SceneManager.LoadScene("MenuEndScene");
            m.OnLevelWasLoaded(3);
        }
    }
    public void DisplayScore()
    {
        totalMonster.text = calscore.score.ToString();
        //Debug.Log("the score is " + score);
    }
}
