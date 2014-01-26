using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

void Update()
	{
		if (Input.GetMouseButton(0))
		{
			Application.LoadLevel(0);
		}
	}
}