using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MCalculator : MonoBehaviour {

    public int score;
    public TextMesh totalMonster;
    public float timeRemaining;
    public TextMesh timerText;
    public bool daynight = true;

    private const string day ="DayScene";
    private const string night ="NightScene";
    public void DisplayScore()
    {
        totalMonster.text = score.ToString();
        //Debug.Log("the score is " + score);
    }
	// Use this for initialization
	void Start () {
        totalMonster.text = score.ToString();
        Scene scene = SceneManager.GetActiveScene();
        if(scene.name==day)
        {
            daynight = false;
        }
        else if(scene.name==night)
        {
            daynight = true;
        }

    }

    // Update is called once per frame
    void Update () {
        //DisplayScore();
        timeRemaining -=  Time.deltaTime;
        timerText.text = Mathf.Floor(timeRemaining).ToString();
        if(timeRemaining<1)
        {
            if (daynight)
            {
                SceneManager.LoadScene("DayScene");
                daynight = !daynight;
            }
            else
            {
                SceneManager.LoadScene("NightScene");
                daynight = !daynight;
            }            
        }
    }
}
