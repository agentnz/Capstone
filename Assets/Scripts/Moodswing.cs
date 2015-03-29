using UnityEngine;
using System.Collections;

public class Moodswing : MonoBehaviour {
	
	//public GameObject objectHolder;
	public ObjectLists objects;
	//private ObjectLists objects = objectHolder.GetComponent<ObjectLists>();

	void OnTriggerEnter(Collider other) {
		foreach (Light light in objects.lightsOn)
			light.enabled = true;
		foreach (Light light in objects.lightsOff)
			light.enabled = false;
		foreach (MeshRenderer mesh in objects.meshesOn)
			mesh.enabled = true;
		foreach (MeshRenderer mesh in objects.meshesOff)
			mesh.enabled = false;
		/*foreach (Object obj in objsOn ) {
			Light light = obj as Light;
			if (light != null)
				light.enabled = true;
		}*/
	}
}
