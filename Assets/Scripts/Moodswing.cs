using UnityEngine;
using System.Collections;

public class Moodswing : MonoBehaviour {
	
	public Light[] lightsOn, lightsOff;
	public MeshRenderer[] meshesOn, meshesOff;
	
	void OnTriggerEnter(Collider other) {
		foreach (Light light in lightsOn)
			light.enabled = true;
		foreach (Light light in lightsOff)
			light.enabled = false;
		foreach (MeshRenderer mesh in meshesOn)
			mesh.enabled = true;
		foreach (MeshRenderer mesh in meshesOff)
			mesh.enabled = false;
	}
}
