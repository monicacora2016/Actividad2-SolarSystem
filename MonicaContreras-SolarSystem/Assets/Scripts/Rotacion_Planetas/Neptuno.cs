using UnityEngine;
using System.Collections;

public class Neptuno : MonoBehaviour {
	void Update() {
		transform.RotateAround(Vector3.zero, Vector3.up, 2 * Time.deltaTime);
	}
}

