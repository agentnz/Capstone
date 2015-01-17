using UnityEngine;
using System.Collections;

public class SunStone : MonoBehaviour {
	
	public Light sunlight, moonlight;
	
	void OnTriggerEnter(Collider other) {
		Debug.Log ("Sun Stone active!");
		sunlight.enabled = true;
		moonlight.enabled = false;
	}
}
