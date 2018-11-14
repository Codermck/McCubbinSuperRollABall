using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectiblesController : MonoBehaviour {
	
	public bool isCollected 

	// Use this for initialization
	void Start () {
		isCollected = false
	}
	
	// Update is called once per frame
	void Update () {
		if (isCollected)
		{
			Debug.Log ("isCollected has been set to true for me!");
			Destroy (this.gameObject, if);
			void Disappear()
			{
				rb.AudioVelocityUpdateMode += (this.transform.forward * 20f * Time.deltaTime);
	}
}
	