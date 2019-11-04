using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.A)){
			Debug.Log ("Has pulsado la Letra A. <color=#f3ee7f>Amarillo</color> empieza por A.");
		}
	
		if(Input.GetKey(KeyCode.R)){
			Debug.Log ("Has pulsado la Letra R. <color=#f3ee7f>Rojo</color> empieza por R.");
		}

		if(Input.GetKey(KeyCode.V)){
			Debug.Log ("Has pulsado la Letra V. <color=#7ff382>Verde</color> empieza por V.");
		}

		if(Input.GetKey(KeyCode.N)){
			Debug.Log ("Has pulsado la Letra N. <b>Negrita</b> empieza por N.");
		}
	}
}
