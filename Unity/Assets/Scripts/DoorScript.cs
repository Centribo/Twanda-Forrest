using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour {

	bool isOpen = false;
	Vector3 closedPos;
	Vector3 openedPos;
	public Vector3 openDoorDelta;
	
	// Use this for initialization
	void Start ()
	{
		closedPos = this.transform.position;
		openedPos = closedPos + openDoorDelta;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
	
	public void openDoor ()
	{
		this.transform.position = openedPos;
		isOpen = true;
	}
	
	public void closeDoor ()
	{
		this.transform.position = closedPos;
		isOpen = false;
	}
}
