using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarClickEnObjetoRayoDesdeCamara : MonoBehaviour {

	Ray _pulsacion;
	RaycastHit _colision; //Almacena Informacion


	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
		if(Input.GetMouseButton(0))//boton izquierdo:0 boton derecho: 1 boton central: 2
		{
			_pulsacion = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast (_pulsacion,out _colision)) {
				
				_colision.collider.gameObject.GetComponent<Transform>().Rotate(new Vector3(0.5F,0.5F,0.5F));


			}
		}

	}
}
