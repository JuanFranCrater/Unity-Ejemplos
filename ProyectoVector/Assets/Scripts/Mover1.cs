using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover1 : MonoBehaviour {

	public int _limMenor = -5;
	public int _limMayor =5;
	public float _velocidad = 1F;
	float xMove;
	float zMove;
	Vector3 clampedPositionx;
	Vector3 clampedPositionz;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//nueva movimiento
		xMove = Input.GetAxis("Horizontal") * Time.deltaTime;
		zMove = Input.GetAxis ("Vertical") * Time.deltaTime;

		transform.Translate(xMove,0f , zMove);

		// vector inicial
		clampedPositionx = transform.position;
		// Ahora recolocamos
		clampedPositionx.x = Mathf.Clamp(transform.position.x*_velocidad, _limMenor, _limMayor);
		transform.position = clampedPositionx;

		clampedPositionz = transform.position;
		clampedPositionz.z = Mathf.Clamp (transform.position.z*_velocidad, _limMenor, _limMayor);
		transform.position = clampedPositionz;
	}
}
