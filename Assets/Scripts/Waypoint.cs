using UnityEngine;
using System.Collections;

public class Waypoint : MonoBehaviour {

	public Transform[] waypoints;
	private int i = 0;
	private bool gameWon = false;
	public GameObject player;
	public GameObject landmines;
	
	void OnTriggerEnter(Collider other) {
		transform.position = waypoints [i].position;
		i++;
		if (i == waypoints.Length - 1) {
			foreach (CapsuleCollider collider in landmines.GetComponentsInChildren<CapsuleCollider>()) {
				collider.enabled = true;
			}
		}
		if (i == waypoints.Length) {
			foreach (CapsuleCollider collider in landmines.GetComponentsInChildren<CapsuleCollider>()) {
				collider.enabled = false;
			}
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
