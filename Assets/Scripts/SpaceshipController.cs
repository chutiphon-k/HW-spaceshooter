using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipController : MonoBehaviour {

	public GameObject myBullet;
	public AudioClip[] soundShooting = new AudioClip[3];
	public int count = 0;
	public Material[] BulletColor = new Material[3];
	public Renderer rend;
	// Use this for initialization
	void Start () {
		rend = myBullet.GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetAxis("Horizontal") != 0 ) {
			this.gameObject.transform.Translate (Input.GetAxis ("Horizontal") * Vector3.right * Time.deltaTime *10f);
		}

		if (Input.GetKeyDown(KeyCode.Space)) {
			this.gameObject.GetComponent<AudioSource> ().clip = soundShooting[Random.Range(0, 3)];
			this.gameObject.GetComponent<AudioSource> ().Play ();
			rend.sharedMaterial = BulletColor[Random.Range(0, 3)];
			count++;
//			Debug.Log (myBullet.GetComponent<Renderer>.material);
			Instantiate (myBullet,this.gameObject.transform.position,Quaternion.identity);
		}
		
	}
}
