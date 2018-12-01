using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectMonsters : MonoBehaviour {

    MCalculator mcalc;
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("redmonster")|| other.CompareTag("bluemonster")|| other.CompareTag("violetmonster")|| other.CompareTag("yellowmonster"))
        {
            mcalc.score++;
            mcalc.DisplayScore();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        
        
    }
    public void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.CompareTag("ground"))
        {
            Destroy(gameObject);
        }
    }
    // Use this for initialization
    void Start () {
        mcalc = FindObjectOfType<MCalculator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
