using UnityEngine;
using System.Collections;

public class RiddleCompare : MonoBehaviour {

	public int correctVal;
	public int moodVal;

	// Use this for initialization
	void Start () {
		if (MoodManager.mood == moodVal) 
		{
			this.gameObject.tag = "Answer";
		}
		if (Riddle.riddleval == correctVal) {
			this.gameObject.tag = "Answer";
		}

		else
			this.gameObject.tag = "Enemy";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
