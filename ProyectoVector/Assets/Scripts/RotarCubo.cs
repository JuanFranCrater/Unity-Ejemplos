using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarCubo : MonoBehaviour {

	public float x = 0;
	public float y = 0;
	public float z = 0;
	public float w = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = new Quaternion (x,y,z,w);
		Debug.Log ("X->"+x);
		Debug.Log ("Y->"+x.ToString("00"));
	}
}
