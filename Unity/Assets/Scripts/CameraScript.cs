using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour
{

		float initialZoom;
		float initialZoom2;
		float zoomTimePassed;
		float zoomTimePassed2;
		float TOTALZOOMTIME = 5;
		public float newZoom;

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
				if (c.transform.name == "player1") {
						zoomTimePassed = 0;
						initialZoom = GameObject.Find ("Player One Camera").camera.orthographicSize;
				} else if (c.transform.name == "player2") {		
						zoomTimePassed2 = 0;
						initialZoom2 = GameObject.Find ("Player Two Camera").camera.orthographicSize;
				}
		}

		void OnTriggerStay2D (Collider2D c)
		{
				if (c.transform.name == "player1") {		
						zoomTimePassed += Time.deltaTime;
		
						float t = zoomTimePassed / TOTALZOOMTIME;
		
						GameObject.Find ("Player One Camera").camera.orthographicSize = Mathf.SmoothStep (initialZoom, newZoom, t);
				} else if (c.transform.name == "player2") {		
						zoomTimePassed2 += Time.deltaTime;
			
						float t = zoomTimePassed2 / TOTALZOOMTIME;
			
						GameObject.Find ("Player Two Camera").camera.orthographicSize = Mathf.SmoothStep (initialZoom2, newZoom, t);
				}
		}
}
