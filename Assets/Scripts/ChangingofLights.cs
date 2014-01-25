using UnityEngine;
using System.Collections;

public class ChangingofLights : MonoBehaviour  {
	/*public int lightChange = 1;
	//public bool lightChanger;
	public float resetTimer = 0.5f;*/  // Not needed
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (MoodManager.mood == 0) {
			light.color = Color.white;
		}
		if (MoodManager.mood == 1) { // References "mood" from MoodManager.cs
			light.color = Color.magenta;
		}
		if (MoodManager.mood == 2) {
			light.color = Color.blue;

		}
		if (MoodManager.mood == 3) {
			light.color = Color.red;
		}
		if (MoodManager.mood == 4) {
			light.color = new Color32 (255, 147, 0, 255);
		}
		if (MoodManager.mood == 5) {
			light.color = Color.black;
		}
	}
	
}