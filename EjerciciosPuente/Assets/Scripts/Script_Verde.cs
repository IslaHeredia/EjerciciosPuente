using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Verde : MonoBehaviour {
	
	public float velocidad = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.E)){
			Debug.Log ("Pulsada la tecla E.");
			transform.Translate (Vector2.left * velocidad * Time.deltaTime);
			Debug.Log ("Sprite Verde se mueve a la izquierda");
		}

		if(Input.GetKey(KeyCode.F)){
			Debug.Log ("Pulsada la tecla F.");
			transform.Translate (Vector2.right * velocidad * Time.deltaTime);
			Debug.Log ("Sprite Verde se mueve a la derecha");
		}

		if(Input.GetKey(KeyCode.G)){
			Debug.Log ("Pulsada la tecla G.");
			transform.Translate (Vector2.up * velocidad * Time.deltaTime);
			Debug.Log ("Sprite Verde se mueve arriba");
		}

		if(Input.GetKey(KeyCode.H)){
			Debug.Log ("hemos pulsado la tecla H.");
			transform.Translate (Vector2.down * velocidad * Time.deltaTime);
			Debug.Log ("Sprite Verde se mueve abajo");
		}

	}
}
