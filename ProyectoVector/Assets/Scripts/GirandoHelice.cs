using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirandoHelice : MonoBehaviour {

	public float x = 2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (x, 0, 0);
	}
}
