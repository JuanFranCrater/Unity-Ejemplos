using UnityEngine;
using System.Collections;

public class MathfPrueba : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		Mathf.IsPowerOfTwo (120);
		Mathf.PingPong (0.4F, 0.6F);
		Mathf.Clamp (0.1F,0.0F,10.0F);
	}
}

