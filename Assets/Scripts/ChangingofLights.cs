using UnityEngine;
using System.Collections;

public class ChangingofLights : MonoBehaviour  {
	public int lightChange = 1;
	//public bool lightChanger;
	public float resetTimer = 0.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(lightChange == 1)
		{
			light.color = Color.blue;
				
		}
		if (lightChange == 2)
		{
			light.color = Color.red;

		}
		
	}
	
}