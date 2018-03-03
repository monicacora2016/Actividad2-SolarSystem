using UnityEngine;
using System.Collections;

public class Tierra : MonoBehaviour {
	void Update() {
		transform.RotateAround(Vector3.zero, Vector3.up, 4 * Time.deltaTime);
	}
}
