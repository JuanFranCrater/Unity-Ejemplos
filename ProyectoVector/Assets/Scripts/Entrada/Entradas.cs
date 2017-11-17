using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entradas : MonoBehaviour {


		public KeyCode _arriba;
		public KeyCode _abajo;
	public float _velocidad = 0.2F;

	void Update()
	{
		//Si pulso 'arriba' se mueve en Y+
		if (Input.GetKey (_arriba)) {
			
			transform.Translate (0, _velocidad, 0);
		}
		//Si pulso 'abajo' se mueve en Y-
		if (Input.GetKey (_abajo)) {
			transform.Translate (0,- _velocidad, 0);
		}

		//Pa' salir
		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit ();
		}
	}

}
