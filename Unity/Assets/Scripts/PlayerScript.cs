using UnityEngine;
using System.Collections;
using System;

public class PlayerScript : MonoBehaviour
{

		public int acceleration = 5;
		public int maxSpeed = 5;
		public int jumpForce = 70;
		private bool isOnGround = false;
		public int playerNumber = 0;
	
		// Use this for initialization
		void Start ()
		{
		}
	
		// Update is called once per frame
		void Update ()
		{
				bool jump = Input.GetButton ("JumpKey");

				switch (playerNumber) {
				case 1:
						bool playerOneLeft = Input.GetButton ("PlayerOneLeftKey");
						bool playerOneRight = Input.GetButton ("PlayerOneRightKey");
			
						if (playerOneRight) {
								//this.transform.Translate (Vector2.right * speed * Time.deltaTime);
								this.rigidbody2D.AddForce (Vector2.right * acceleration);
						} else if (playerOneLeft) {
								//this.transform.Translate (-Vector2.right * speed * Time.deltaTime);
								this.rigidbody2D.AddForce (Vector2.right * -acceleration);
						}
						break;
				case 2:
						bool playerTwoLeft = Input.GetButton ("PlayerTwoLeftKey");
						bool playerTwoRight = Input.GetButton ("PlayerTwoRightKey");
			
						if (playerTwoRight) {
								//this.transform.Translate (Vector2.right * speed * Time.deltaTime);
								this.rigidbody2D.AddForce (Vector2.right * acceleration);
						} else if (playerTwoLeft) {
								//this.transform.Translate (-Vector2.right * speed * Time.deltaTime);
								this.rigidbody2D.AddForce (Vector2.right * -acceleration);
						}
						break;
				}
				if (this.rigidbody2D.velocity.x > maxSpeed) {
						this.rigidbody2D.velocity = new Vector2 (maxSpeed, this.rigidbody2D.velocity.y);
				} else if (this.rigidbody2D.velocity.x < -maxSpeed) {
						this.rigidbody2D.velocity = new Vector2 (-maxSpeed, this.rigidbody2D.velocity.y);
				}
				
				float distance = (this.GetComponent<BoxCollider2D> ().size.y * 0.5f * this.transform.localScale.x) + 0.016f;
				Collider2D hit = Physics2D.OverlapPoint (new Vector2 (this.transform.position.x, this.transform.position.y - distance));
				if (hit.transform.tag == "Platform" || hit.transform.name == "floor") {
						this.isOnGround = true;
				} else {
						this.isOnGround = false;
				}
				//print (hit.tag);
				//Debug.DrawRay (new Vector3 (0, 0, 0), new Vector3 (this.transform.position.x, this.transform.position.y - distance, 0));
				/* Vector2 origin = (Vector2)this.transform.position + (-Vector2.up * distance);
				
				RaycastHit2D hit = Physics2D.Raycast (origin, -Vector2.up, 0.01f);
				Debug.DrawRay (origin, (-Vector2.up * 0.01f));

				Debug.Log (hit.transform.tag);
				if (hit.transform.tag == "Platform") {
						this.isOnGround = true;
				} else {
						this.isOnGround = false;
				} */

				if (jump && this.isOnGround) {
						this.transform.Translate (Vector2.up * 0.016f);
						this.rigidbody2D.AddForce (new Vector2 (0, jumpForce));
						this.isOnGround = false;
				}
		}
	
		
}
	