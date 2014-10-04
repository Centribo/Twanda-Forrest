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
	
		void OnTriggerEnter2D (Collider2D c)
		{
				print ("test");
				if (c.transform.tag == "Player") {
						door.GetComponent<DoorScript> ().openDoor ();
				}
		}
	
		void OnTriggerExit2D (Collider2D c)
		{
				if (c.transform.tag == "Player") {
						door.GetComponent<DoorScript> ().closeDoor ();
				}
		}
}
