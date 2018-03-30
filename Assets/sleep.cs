using UnityEngine;
using System.Collections;

public class sleep : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// Enable sleep at startup
		Rigidbody r = GetComponent<Rigidbody>();
		r.Sleep ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
