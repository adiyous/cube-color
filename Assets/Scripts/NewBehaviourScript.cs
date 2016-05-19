using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour
{
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.R))
		{
			GetComponent<Renderer> ().material.color = Color.red;
		}
		if (Input.GetKeyDown(KeyCode.G))
		{
			GetComponent<Renderer>().material.color = Color.green;
		}
		if (Input.GetKeyDown(KeyCode.B))
		{
			GetComponent<Renderer>().material.color = Color.blue;
		}

		//Added by Rafa Infante YMCK
		if (Input.GetKeyDown(KeyCode.Y))
		{
			GetComponent<Renderer>().material.color = Color.yellow;
		}

		if (Input.GetKeyDown(KeyCode.M))
		{
			GetComponent<Renderer>().material.color = Color.magenta;
		}

		if (Input.GetKeyDown(KeyCode.C))
		{
			GetComponent<Renderer>().material.color = Color.cyan;
		}

		if (Input.GetKeyDown(KeyCode.K))
		{
			GetComponent<Renderer>().material.color = Color.black;
		}
	}
}
