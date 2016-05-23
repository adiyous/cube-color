using UnityEngine;
using System.Collections;
//spining cube
public class move : MonoBehaviour {

	public float speed = 100f;

	void Update ()
	{
		transform.Rotate(Vector3.up, speed * Time.deltaTime);
	}
}
