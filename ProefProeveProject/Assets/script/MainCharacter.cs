using UnityEngine;
using System.Collections;

public class MainCharacter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)) {
			rigidbody2D.AddForce(new Vector2(0,100));
			Debug.Log("down" + Time.deltaTime);
		} else if(Input.GetMouseButtonUp(0)) {
			Debug.Log("up" + Time.deltaTime);
		} else if(Input.GetMouseButton(0)) {
			Debug.Log("change" + Time.deltaTime);
		}
	}
}
