using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover1_2D : MonoBehaviour {

	public int _limMenor = -10;
	public int _limMayor = 10;
	public float _velocidad = 1F;
	int _valor = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		_valor += (int)(Input.GetAxis ("Horizontal") * _velocidad);
		_valor = Mathf.Clamp (_valor, _limMenor, _limMayor);
		transform.position = new Vector3 (_valor, 0, 0);
	}
}
