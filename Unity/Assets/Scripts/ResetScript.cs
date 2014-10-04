using UnityEngine;
using System.Collections;

public class ResetScript : MonoBehaviour {

	public Vector3 resetPos; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D c)
	{
		if (c.transform.tag == "Player") {
			c.attachedRigidbody.position = resetPos;
			c.attachedRigidbody.velocity = Vector2.zero;
		}
	}
}
