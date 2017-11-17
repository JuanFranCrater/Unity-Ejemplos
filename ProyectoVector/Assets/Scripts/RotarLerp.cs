using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarLerp : MonoBehaviour {

	public Transform _desde;
	public Transform _a;
	public float _velocidad = 0.1F;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.Lerp (_desde.rotation, _a.rotation, Time.time * _velocidad);
	}
}
