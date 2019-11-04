using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Azul : MonoBehaviour {

	public float velocidad = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.C)){
			Debug.Log ("Pulsada la tecla C.");
			transform.Translate (Vector2.up * velocidad * Time.deltaTime);
			Debug.Log ("Sprite Azul se Mueve a la arriba");
		}

		if(Input.GetKey(KeyCode.D)){
			Debug.Log ("hemos pulsado la tecla B.");
			transform.Translate (Vector2.down * velocidad * Time.deltaTime);
			Debug.Log ("Sprite Azul se Mueve a la abajo");
		}
	}
}
