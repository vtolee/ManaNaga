using UnityEngine;
using System.Collections;

public class RotateObject : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 euler = transform.eulerAngles;
		euler.y +=  20 * Time.deltaTime;
		transform.rotation = Quaternion.Euler(euler);
	}
}
