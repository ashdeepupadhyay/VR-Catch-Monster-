using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScoreDisplay : MonoBehaviour {
    CalculateScore calScore;
    private int monsterCount = 0;
    public Text monstertext;
    // Use this for initialization
    void Start () {
        
        calScore = FindObjectOfType<CalculateScore>();
        monsterCount = calScore.score;
        monstertext.text = monsterCount.ToString();
        Destroy(calScore.gameObject);
        


    }

    // Update is called once per frame
    void Update () {
		
	}
}
