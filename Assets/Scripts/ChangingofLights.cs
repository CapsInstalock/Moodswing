using UnityEngine;
using System.Collections;

public class ChangingofLights : MonoBehaviour  {
	public bool lightChange;
	public bool lightChanger;
	public float resetTimer = 0.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(lightChange)
		{
			light.color = Color.blue;
				
		}
		else if (lightChanger)
		{
			light.color = Color.blue;

		}
		
	}
	
}