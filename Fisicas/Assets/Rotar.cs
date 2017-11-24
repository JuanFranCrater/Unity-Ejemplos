using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar : MonoBehaviour {
	public float rotacionY=100F;
	public float rotacionX = 100F;
	public float g = 0.5F; 
	public Transform objetivo;
	public Rigidbody _rigidBody;
	Vector3 posicionRelativa;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	/*	if(Input.GetKeyDown(KeyCode.A))
		{
			RotarEnY (rotacionY);
		}else if(Input.GetKeyDown(KeyCode.S))
		{
			RotarEnY (rotacionX);
		}
		Invoke ("RotarEnXY", g);
		*/
		Invoke ("MirarAlObjetivo", g);
		Invoke ("IrAlObjetivo", g);
	}
	void RotarEnY(float grados)
	{
		//Rota instantaneamente a la posicion indicada
		GetComponent<Rigidbody>().rotation = Quaternion.Euler(new Vector3(0F,grados,0F));
	}
	void RotarEnX(float grados)
	{
		//Rota instantaneamente a la posicion indicada
		GetComponent<Rigidbody>().rotation = Quaternion.Euler(new Vector3(grados,0F,0F));
	}
	void RotarEnXY()
	{
		RotarEnX (150);
		RotarEnY (150);
	}
	void IrAlObjetivo()
	{
		Vector3 fuerzaEmpuje = posicionRelativa;
		_rigidBody.AddForce (fuerzaEmpuje);
	}
	void MirarAlObjetivo()
	{
		/*Obtener la posicion relativa de este objeto con respecto a que va a mirar, se consigue restando ambas posiciones
		
		*/
		 posicionRelativa = objetivo.position - transform.position;

		//Obtener el Quaternion para aplicar la rotacion

		Quaternion rotacion = Quaternion.LookRotation (posicionRelativa);

		//Aplicar la rotacion
		GetComponent<Rigidbody>().rotation = rotacion;
	}
}
