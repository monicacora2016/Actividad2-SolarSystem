using UnityEngine;
using System.Collections;

public class Venus : MonoBehaviour {
	void Update() {
		transform.RotateAround(Vector3.zero, Vector3.up, 5 * Time.deltaTime);
	}
}
