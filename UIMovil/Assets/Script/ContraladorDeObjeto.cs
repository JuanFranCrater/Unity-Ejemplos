using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Asignado al objeto a controlar
public class ContraladorDeObjeto : MonoBehaviour {

	float _velocidad =5.0F; //velocidad de desplazamiento del objeto asigando en x, y
	float _veloZoom = 0.5F; //para hacer Zoom

	//valores para la accion realizada
	bool derecha = false;
	bool izquierda= false;
	bool arriba = false;
	bool abajo = false;
	bool aumentar = false;
	bool disminuir = false;

	void Update () {
		if (derecha) {
			transform.Translate (Vector3.right * Time.deltaTime * _velocidad);
		}
		if (arriba) {
			transform.Translate (Vector3.up * Time.deltaTime * _velocidad);
		}
		if (izquierda) {
			transform.Translate (Vector3.left * Time.deltaTime * _velocidad);
		}
		if (abajo) {
			transform.Translate (Vector3.down * Time.deltaTime * _velocidad);
		}
		if (aumentar) {
			transform.localScale= new Vector3(transform.localScale.x+_veloZoom,transform.localScale.y+_veloZoom,transform.localScale.z+_veloZoom);
		}
		if (disminuir) {
			transform.localScale= new Vector3(transform.localScale.x-_veloZoom,transform.localScale.y-_veloZoom,transform.localScale.z-_veloZoom);
		}

	}

	public void MoverDerecha()
	{
		derecha = true;
	}
	public void MoverIzquierda()
	{
		izquierda = true;
	}
	public void MoverArriba()
	{
		arriba = true;
	}
	public void MoverAbajo()
	{
		abajo = true;
	}
	public void AumentarEscala()
	{
		aumentar = true;
	}
	public void DisminuirEscala()
	{
		disminuir = true;
	}
	public void Detener()
	{
		derecha = false;
		izquierda = false;
		arriba = false;
		abajo = false;
		aumentar = false;
		disminuir = false;
	}

}
