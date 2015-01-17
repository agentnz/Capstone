using UnityEngine;
using System.Collections;

public class MoonStone : MonoBehaviour {

	public Light sunlight, moonlight;

	void OnTriggerEnter(Collider other) {
		Debug.Log ("Moon Stone active!");
		sunlight.enabled = false;
		moonlight.enabled = true;
	}
}
