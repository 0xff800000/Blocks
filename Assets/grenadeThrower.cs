using UnityEngine;
using System.Collections;

public class grenadeThrower : MonoBehaviour {
	public float throwForce = 10f;
	public GameObject grenadeFab;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (1)) {
			throwGrenade ();
		}
	}

	void throwGrenade(){
		GameObject grenade = (GameObject) Instantiate (grenadeFab, transform.position+(transform.forward*2) , transform.rotation);
		Rigidbody rb = grenade.GetComponent<Rigidbody> ();
		rb.AddForce (transform.forward * throwForce);
	}
}
