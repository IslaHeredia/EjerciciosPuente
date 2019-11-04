using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_Comparaciones : MonoBehaviour {
	public int numeroUno;
	public int numeroDos;


	// Use this for initialization
	void Start () {
		if (numeroUno < numeroDos) {
			Debug.Log (numeroUno + " es menor que " + numeroDos);
		}

		if (numeroUno > numeroDos) {
			Debug.Log (numeroUno + " es mayor que " + numeroDos);
		}

		if (numeroUno == numeroDos) {
			Debug.Log (numeroUno + " es igual a " + numeroDos);
		}
			
	}
	
	// Update is called once per frame
	void Update () {



	}
}
