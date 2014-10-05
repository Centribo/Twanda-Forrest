using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour
{

		bool isOpen = false;
		Vector3 closedPos;
		Vector3 openedPos;
		public int openDoorDelta;
		public bool isGate = false;
		bool opened = false;

		// Use this for initialization
		void Start ()
		{
				closedPos = this.transform.position;
				openedPos = new Vector3 (closedPos.x, closedPos.y + openDoorDelta, 0);
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (isOpen || opened) {
						this.transform.position = this.transform.position + new Vector3 (0, 0.1f, 0);
						if (this.transform.position.y > openedPos.y) {
								this.transform.position = openedPos;
						}
				} else {
						if (!isGate) {
								this.transform.position = this.transform.position + new Vector3 (0, -0.1f, 0);
								if (this.transform.position.y < closedPos.y) {
										this.transform.position = closedPos;
								}
						}
				}
		}
	
		public void openDoor ()
		{
				//this.transform.position = openedPos;
				isOpen = true;
				if (isGate) {
						opened = true;
				}
		}
	
		public void closeDoor ()
		{
				//this.transform.position = closedPos;
				isOpen = false;
		}
}
