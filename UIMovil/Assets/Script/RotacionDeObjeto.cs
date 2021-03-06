using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionDeObjeto : MonoBehaviour {

	 //velocidad de rotacion del objeto asigando en x, y
	public float _velocidad = 3.0F; 

	//valores para la accion realizada
	bool derecha = false;
	bool izquierda= false;
	bool arriba = false;
	bool abajo = false;

	void Update () {
		if (derecha) {
			transform.Rotate (Vector3.right * Time.deltaTime * _velocidad);
		}
		if (arriba) {
			transform.Rotate (Vector3.up * Time.deltaTime * _velocidad);
		}
		if (izquierda) {
			transform.Rotate (Vector3.left * Time.deltaTime * _velocidad);
		}
		if (abajo) {
			transform.Rotate (Vector3.down * Time.deltaTime * _velocidad);
		}

	}

	public void RotarDerecha()
	{
		derecha = true;
	}
	public void RotarIzquierda()
	{
		izquierda = true;
	}
	public void RotarArriba()
	{
		arriba = true;
	}
	public void RotarAbajo()
	{
		abajo = true;
	}

	public void Detener()
	{
		derecha = false;
		izquierda = false;
		arriba = false;
		abajo = false;
	}
}
