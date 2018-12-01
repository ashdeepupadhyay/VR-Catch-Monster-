using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MCalculator : MonoBehaviour {

    public int score;
    public TextMesh totalMonster;
    public float timeRemaining;
    public TextMesh timerText;
    public void DisplayScore()
    {
        totalMonster.text = score.ToString();
        //Debug.Log("the score is " + score);
    }
	// Use this for initialization
	void Start () {
        totalMonster.text = score.ToString();

    }
	
	// Update is called once per frame
	void Update () {
        //DisplayScore();
        timeRemaining -=  Time.deltaTime;
        timerText.text = Mathf.Floor(timeRemaining).ToString();
        if(timeRemaining<1)
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
