using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{

		public int speed = 5;
		public int jumpForce = 70;
		bool isOnGround = false;
	
		// Use this for initialization
		void Start ()
		{
		
		}
	
		// Update is called once per frame
		void Update ()
		{
				bool left = Input.GetButton ("leftKey");
				bool right = Input.GetButton ("rightKey");
				bool up = Input.GetButton ("upKey");
				if (right) {
						this.transform.Translate (Vector2.right * speed * Time.deltaTime);
				} else if (left) {
						this.transform.Translate (-Vector2.right * speed * Time.deltaTime);
				}
				if (up && isOnGround) {
						this.rigidbody2D.AddForce (new Vector2 (0, jumpForce));
						isOnGround = false;
				}
		}
	
		void OnCollisionEnter2D (Collision2D c)
		{
				if (c.transform.tag == "Floor" || c.transform.tag == "Switch") {
						isOnGround = true;
				}
		}
}
