using UnityEngine;
using System.Collections;

public class Waypoint : MonoBehaviour {

	public Transform[] waypoints;
	private int i = 0;
	private bool gameWon = false;
	public GameObject player;
	
	void OnTriggerEnter(Collider other) {
		transform.position = waypoints [i].position;
		i++;
		if (i == waypoints.Length) {
			gameWon = true;
			player.GetComponent<CharacterMotor>().movement.gravity = 0;
		}
	}

	void Update() {
		if (gameWon) {
			player.transform.Translate(Vector3.up * Time.deltaTime, Space.World);
		}
	}
}
