using UnityEngine;
using System.Collections;
using System;

public class PlayerScript : MonoBehaviour
{

		public int acceleration = 5;
		public int maxSpeed = 5;
		public int jumpForce = 70;
		bool isOnGround = false;
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
				
				if (jump && isOnGround) {
						this.rigidbody2D.AddForce (new Vector2 (0, jumpForce));
						isOnGround = false;
				}
		}
	
		void OnCollisionEnter2D (Collision2D c)
		{
				if (c.transform.tag == "Platform") {
						isOnGround = true;
				}
		}
}
