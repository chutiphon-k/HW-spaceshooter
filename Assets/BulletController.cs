using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

	public AudioClip myExplosion;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Translate (Vector3.up * Time.deltaTime * 10f);
		if (this.gameObject.transform.position.y >= 20f) {
			Destroy (this.gameObject);
		}
	}

	void OnTriggerEnter (Collider other) {
		Debug.Log (other.gameObject.GetComponent<EnemyController>().getCount());
//		Component obj = other.gameObject.GetComponent<EnemyController>();
		if (other.gameObject.GetComponent<EnemyController>().getCount() >= 3) {
			other.gameObject.GetComponent<EnemyController>().setCount (0);
			Destroy (other.gameObject);
		}
//		Destroy (other.gameObject);
//		this.gameObject.GetComponent<AudioSource> ().clip = myExplosion;
//		this.gameObject.GetComponent<AudioSource> ().Play ();
		//Destroy (this.gameObject);

	}
}
