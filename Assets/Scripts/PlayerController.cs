using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float movementSpeed;
	public float rotateSpeed;

	private Animation anim;

	void Start () {
		anim = GetComponent<Animation> ();
	}

	void Update () {
		if (Input.anyKey) {
			anim.Play ("Run");
			if (Input.GetKey (KeyCode.W)) 
				transform.Translate (Vector3.forward * movementSpeed * Time.deltaTime);
			if (Input.GetKey (KeyCode.A)) 
				transform.Translate (Vector3.left * movementSpeed * Time.deltaTime);
			if (Input.GetKey (KeyCode.S)) 
				transform.Translate (Vector3.back * movementSpeed * Time.deltaTime);
			if (Input.GetKey (KeyCode.D)) 
				transform.Translate (Vector3.right * movementSpeed * Time.deltaTime);
			/*if (Input.GetKey (KeyCode.UpArrow)) 
				transform.Rotate(Vector3.forward*rotateSpeed*Time.deltaTime);*/
			if (Input.GetKey (KeyCode.LeftArrow)) 
				transform.Rotate (Vector3.down * rotateSpeed * Time.deltaTime);
			/*if (Input.GetKey (KeyCode.DownArrow)) 
				transform.Rotate(Vector3.back*rotateSpeed*Time.deltaTime);*/
			if (Input.GetKey (KeyCode.RightArrow)) 
				transform.Rotate (Vector3.up * rotateSpeed * Time.deltaTime);
		} else {
			anim.Play ("idle");
		}
	}
}