using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDriver : MonoBehaviour {

	/*
	tipe data utk angka (bilangan bulat)
		- int => menyimpan angka dari -2,147,483,648 - 2,147,483,647
		- long => menyimpan angka dari -9,223,372,036,854,775,808 - 9,223,372,036,854,775,807

	tipe data utk angka (bilangan desimal)
		- float => menyimpan bilangan desimal, jumlah angka desimal yg 
					disimpan maks 6 - 7 angka dibelakang titik [.]
					cth: 1.56f ; 32.03215f; 1514.568412f

		- double => menyimpan bilangan desimal, jumlah angka desimal yg
					disimpan maks 15 angka dibelakang titik [.], lalu diakhiri
					dengan huruf d (tidak wajib)
					cth: 23.541d; 378.1654861555; 0.255563

	tipe data utk huruf, kata, kalimat
		- char => menyimpan 1 huruf
				  cth: 'A' ; 'b' ; 'c'
		- string => menyimpan huruf, kata, dan kalimat
				    cth: "a"; "g"; "hello"; "unity"; "ini sebuah kalimat"
		- bool => menyimpan pernyataan benar (true) atau salah (false)
	*/

	// syntax variable => tipe_data nama_variabel;

	/*
	int angka = 50;
	long angka2 = 56115;
	float angkaDesimal = 2.35f;
	double angkaDesimal2 = 56.412;
	char huruf = 'a';
	string kataKalimat = "ini variabel string";
	bool statementTrue = true;
	bool statement_False = false;
	*/

	[SerializeField] float speedRotate = 1f;
	[SerializeField] float speedPlayer = 1f;



	void Start () {
		// Debug.Log ("hello world");

		/*
		Debug.Log ("variabel angka = " + angka);
		Debug.Log ("variabel angka2 = " + angka2);
		Debug.Log ("variabel angkaDesimal = " + angkaDesimal);
		Debug.Log ("variabel angkaDesimal2 = " + angkaDesimal2);
		Debug.Log ("variabel huruf = " + huruf);
		Debug.Log ("variabel kataKalimat = " + kataKalimat);
		Debug.Log ("variabel statementTrue = " + statementTrue);
		Debug.Log ("variabel statement_False = " + statement_False);
		*/

	}
	
	void Update () {

		//float movePlayer = Input.GetAxis ("Horizontal") * speedPlayer * Time.deltaTime;
		float rotatePlayer = -Input.GetAxis ("Horizontal") * speedRotate * Time.deltaTime;

		if(Input.GetKey(KeyCode.Space)){
			transform.Translate (speedPlayer * Time.deltaTime, 0, 0);
		}

		if(transform.position.x > 27.35f){
			transform.position = new Vector2(27.35f, transform.position.y);
		}
		if(transform.position.x < -27.35f){
			transform.position = new Vector2(-27.35f, transform.position.y);
		}

		if(transform.position.y > 18.4f){
			transform.position = new Vector2(transform.position.x, 18.4f);
		}
		if(transform.position.y < -11.7f){
			transform.position = new Vector2(transform.position.x, -11.7f);
		}

		transform.Rotate (0, 0, rotatePlayer);

	}
}
