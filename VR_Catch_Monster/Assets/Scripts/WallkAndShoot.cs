using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallkAndShoot : MonoBehaviour {

    public GameObject pokeball;
    public float shootSpeed = 10;
    public float speed=2f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += Camera.main.transform.forward * speed * Time.deltaTime;
        if (Input.GetButtonDown("Fire1"))
        {
            var pokego= Instantiate(pokeball);
            pokego.transform.position = gameObject.transform.position;
            Rigidbody rb = pokego.GetComponent<Rigidbody>();
            Camera cam = GetComponentInChildren<Camera>();
            rb.velocity = cam.transform.rotation * Vector3.forward *shootSpeed;
        }


    }
}
