using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMonsters : MonoBehaviour {
    public GameObject []differentMonstors;
	// Use this for initialization
	void Start () {
        for(int i=0;i<100;i++)
        {
            GenerateMonsters();
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GenerateMonsters()
    {
        int monsterindex = Random.Range(0, differentMonstors.Length);
        GameObject rmonster = Instantiate(differentMonstors[monsterindex]);
        rmonster.transform.parent = transform;
        rmonster.transform.localPosition = new Vector3(Random.Range(-99.5f, 99.5f), 0.0f, Random.Range(-99.5f, 99.5f));

    }
}
