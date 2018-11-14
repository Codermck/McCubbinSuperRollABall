﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour {

	public float moveSpeed = 1000f;
	Vector3 offset;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody>();
	
		offset = Camera.main.transform.position - this.transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		float hdir = Input.GetAxisRaw ("Horizontal");
		float vdir = Input.GetAxisRaw ("Vertical");

		Camera.main.transform.position = this.transform.position + offset;

		Vector3 directionVector = new Vector3 (hdir, 0, vdir);
		Vector3 unitVector = directionVector.normalized;
		Vector3 forceVector = unitVector * moveSpeed * Time.deltaTime;

		rb.AddForce(forceVector);
		
	}

	void OnTriggerEnter(Collider other) {

		if (other.gameObject.tag == "Collectible") 
		{
			isCollected = true;
		}
	}
}