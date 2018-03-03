using System.Collections;
using UnityEngine;
using System.Collections;

public class Mercurio: MonoBehaviour {
	void Update() {
		transform.RotateAround(Vector3.zero, Vector3.up, 3 * Time.deltaTime);
	}
}
