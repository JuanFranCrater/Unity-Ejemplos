﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (Mathf.PingPong(Time.time*10F,10F),0,3);
	}
}
