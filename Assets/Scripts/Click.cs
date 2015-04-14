using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			RaycastHit hit;
			//Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			Vector3 origin = new Vector3(0,0,0);
			Vector3 direction = new Vector3(0,0,1);
			float maxDistance = 1;
			
			if (Physics.Raycast(origin, direction, out hit, maxDistance)) {
			print(hit.transform.name + " is clicked by mouse");
			}
		}
	}
}
