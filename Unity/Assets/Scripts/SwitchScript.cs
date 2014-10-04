using UnityEngine;
using System.Collections;

public class SwitchScript : MonoBehaviour
{

		public GameObject door;
	
		// Use this for initialization
		void Start ()
		{
		
		}
	
		// Update is called once per frame
		void Update ()
		{
		
		}
	
		void OnCollisionEnter2D (Collision2D c)
		{
				if (c.transform.tag == "Player") {
						door.GetComponent<DoorScript> ().openDoor ();
				}
		}
	
		void OnCollisionExit2D (Collision2D c)
		{
				if (c.transform.tag == "Player") {
						door.GetComponent<DoorScript> ().closeDoor ();
				}
		}
}
