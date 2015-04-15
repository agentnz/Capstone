using UnityEngine;
using System.Collections;

public class Moodswing : MonoBehaviour {

	public ObjectLists objects;

	void OnTriggerEnter(Collider other) {
		foreach (Light light in objects.lightsOn)
			light.enabled = true;
		foreach (Light light in objects.lightsOff)
			light.enabled = false;
		foreach (MeshRenderer mesh in objects.meshesOn)
			mesh.enabled = true;
		foreach (MeshRenderer mesh in objects.meshesOff)
			mesh.enabled = false;
	}
}
