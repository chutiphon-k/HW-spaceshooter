using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyController : MonoBehaviour {

	public GameObject myEnemy;
	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnEnemy (Random.Range(0.8f, 1.5f)));
	}
	
	// Update is called once per frame
	void Update () {
		//Instantiate (myEnemy, this.gameObject.transform.position, Quaternion.identity);
	}

	IEnumerator SpawnEnemy(float waitTime) {
		
		Instantiate (myEnemy, this.gameObject.transform.position, Quaternion.identity);

		yield return new WaitForSeconds(waitTime);
		StartCoroutine (SpawnEnemy (1f));
	}
}
