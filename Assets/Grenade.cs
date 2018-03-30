using UnityEngine;
using System.Collections;

public class Grenade : MonoBehaviour {
	public float delay = 3f;
	public float radius = 5f;
	public float force = 10f;
	float countdown;
	bool exploded;

	// Use this for initialization
	void Start () {
		countdown = delay;
		exploded = false;
	}
	
	// Update is called once per frame
	void Update () {
		countdown -= Time.deltaTime;
		if (countdown <= 0f && !exploded) {
			explode ();
			exploded = true;
		}
	}

	void explode (){
		Collider [] colliders = Physics.OverlapSphere (transform.position, radius);
		foreach (Collider obj in colliders) {
			Rigidbody rb = obj.GetComponent<Rigidbody> ();
			if (rb != null) {
				rb.AddExplosionForce (force, transform.position, radius);
			}
		}
		Destroy(gameObject);
	}
}
