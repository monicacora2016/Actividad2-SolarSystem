using UnityEngine;
using System.Collections;

public class Marte : MonoBehaviour {
	void Update() {
		transform.RotateAround(Vector3.zero, Vector3.up, 2 * Time.deltaTime);
	}
}
