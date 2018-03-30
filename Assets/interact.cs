﻿using UnityEngine;
using System.Collections;

public class interact : MonoBehaviour {
	public float hitForce = 10f;
	bool isPushing = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetMouseButtonDown (0)) {
			isPushing = true;
		}
		if (Input.GetMouseButtonUp(0)){
			isPushing = false;
		}

		if (isPushing) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if(Physics.Raycast(ray, out hit)){
				if(hit.rigidbody != null) hit.rigidbody.AddForce(ray.direction * hitForce); 
			}
		}
	}
}

