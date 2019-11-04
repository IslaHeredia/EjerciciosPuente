using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Rojo : MonoBehaviour {

	public float velocidad = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.A)){
			Debug.Log ("hemos pulsado la tecla A.");
			transform.Translate (Vector2.left * velocidad * Time.deltaTime);
			Debug.Log ("Sprite Rojo se Mueve a la izquierda");
		}
	
		if(Input.GetKey(KeyCode.B)){
			Debug.Log ("hemos pulsado la tecla B.");
			transform.Translate (Vector2.right * velocidad * Time.deltaTime);
			Debug.Log ("Sprite Rojo se Mueve a la derecha");
		}
	}
}
