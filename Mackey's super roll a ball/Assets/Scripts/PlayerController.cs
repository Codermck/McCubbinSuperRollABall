using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {		
		rb.AddForce(Vector3.forward * -10f);
		
	}
}
