using UnityEngine;
using System.Collections;

public class MoveTank : MonoBehaviour {
	public float rotationSpeed = 2.0f;
	public float movementSpeed = 0.125f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//------------------------------------------------
		if (Input.GetKey(KeyCode.W))
		{
			transform.Translate(Vector3.forward * movementSpeed);


		}
		//------------------------------------------------
		if (Input.GetKey(KeyCode.S))
		{
			transform.Translate(-Vector3.forward * movementSpeed);
			
			
		}
		//------------------------------------------------
		if (Input.GetKey(KeyCode.A))
		{
			transform.Rotate(-Vector3.up * rotationSpeed);
			
			
		}
		//------------------------------------------------
		if (Input.GetKey(KeyCode.D))
		{
			transform.Rotate(Vector3.up * rotationSpeed);
			
			
		}
		//------------------------------------------------
	}
}
