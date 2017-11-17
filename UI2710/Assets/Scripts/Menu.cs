using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//----------------------------------
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
	//public void Jugar(string nombreNivel)
	public void Jugar()
	{
		SceneManager.LoadScene ("EscenaJuego");

	}

	public void Salir()
	{
		Application.Quit();
	}
}
