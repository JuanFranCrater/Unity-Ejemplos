using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LeerFichero : MonoBehaviour {
	GameObject _listado;
	GameObject _texto;

	// Use this for initialization
	void Start () {
		_listado = GameObject.Find ("List");
		_texto = GameObject.Find ("Text");

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LeerFich()
	{
		string line;  
		StreamReader file =new System.IO.StreamReader(@"Assets/List.txt");  
		while((line = file.ReadLine()) != null)  
		{  
			Instantiate (_texto, _listado.GetComponent<Transform>());
		}  

		file.Close();   
	}
}
