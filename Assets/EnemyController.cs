using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	public Material[] EnemyColor = new Material[3];
	public Renderer rend;

	int count = 1;
	// Use this for initialization
	void Start () {
		rend = this.gameObject.GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Translate (Vector3.down * Time.deltaTime * 2f);
	}

	public int getCount(){
		return count;
	}

	public void setCount(int count){
		this.count = count;
	}

	void OnTriggerEnter (Collider other) {
		++count;
		rend.sharedMaterial = EnemyColor[count-1];
		Destroy (other.gameObject);
	}
}
