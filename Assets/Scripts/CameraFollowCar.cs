using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowCar : MonoBehaviour {

	[SerializeField] GameObject carObject;

	void Start () {
		
	}
	
	void LateUpdate () {
		transform.position = carObject.transform.position + new Vector3(0, 0, -50);
	}
}
