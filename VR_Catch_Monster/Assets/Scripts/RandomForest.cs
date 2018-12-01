using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomForest : MonoBehaviour {

    public GameObject[] differentTrees;
    public GameObject[] rocksandgrass;
    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < Random.Range(700,800); i++)
        {
            GenerateDifferentTrees();
        }
        for (int i = 0; i < Random.Range(1100, 1000); i++)
        {
            GenerateRocksAndGrass();
        }
    }

    public void GenerateDifferentTrees()
    {
        int treeindex = Random.Range(0, differentTrees.Length);
        GameObject ttree = Instantiate(differentTrees[treeindex]);
        ttree.transform.parent = transform;
        ttree.transform.localPosition = new Vector3(Random.Range(-99.5f, 99.5f), 0.0f, Random.Range(-99.5f, 99.5f));

    }
    public void GenerateRocksAndGrass()
    {
        int rocksandgrassindex = Random.Range(0, rocksandgrass.Length);
        GameObject rg = Instantiate(rocksandgrass[rocksandgrassindex]);
        rg.transform.parent = transform;
        rg.transform.localPosition = new Vector3(Random.Range(-99.5f, 99.5f), 0.0f, Random.Range(-99.5f, 99.5f));

    }
}
