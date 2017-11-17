using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.Euler (78,12,35);
		transform.eulerAngles = new Vector3 (45,95,62);
		transform.Rotate (new Vector3(12,54,48),Space.Self);
	}
}
