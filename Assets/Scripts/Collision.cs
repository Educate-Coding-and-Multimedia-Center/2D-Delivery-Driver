using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {

	[SerializeField] bool adaPaket;
	[SerializeField] Color32 warnaAwal;
	[SerializeField] Color32 warnaPaket;

	SpriteRenderer spriteRenderer;

	void Start(){
		spriteRenderer = GetComponent<SpriteRenderer> ();
	}

	void OnCollisionEnter2D(Collision2D other){
		Debug.Log ("Ini collison");
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "Paket" && adaPaket == false) {
			Debug.Log ("Paket telah diambil");
			adaPaket = true;
			spriteRenderer.color = warnaPaket;
			Destroy (other.gameObject, 1f);
		}

		if(other.tag == "Box Center" && adaPaket == true){
			Debug.Log ("Paket telah dikirim ke tempat");
			adaPaket = false;
			spriteRenderer.color = warnaAwal;
		}
	}
}
