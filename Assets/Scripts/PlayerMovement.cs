using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float playerSpeed;
	public float rotateSpeed;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(transform.localPosition.x + " > " + LeftLimit);
		//Debug.Log (playerSpeed);
		float HorizontalValue = Input.GetAxis ("Horizontal") * rotateSpeed * Time.deltaTime;
		this.transform.Rotate(Vector3.up * HorizontalValue);
		
		float VerticalValue = Input.GetAxis ("Vertical") * playerSpeed * Time.deltaTime;
		this.transform.Translate(Vector3.forward * VerticalValue);
	}
}
