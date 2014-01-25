using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject zero, one, two, three, four, five;
	public bool activate = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (MoodManager.mood == 0 && activate == false) { // References "mood" from MoodManager.cs
			Instantiate (zero, this.transform.position, Quaternion.identity);
			activate = true;
		}
		if (MoodManager.mood == 1 && activate == false) { 
			Instantiate (one, this.transform.position, Quaternion.identity);
			activate = true;
		}
		if (MoodManager.mood == 2 && activate == false) {
			Instantiate (two, this.transform.position, Quaternion.identity);
			activate = true;
		}
		if (MoodManager.mood == 3 && activate == false) {
			Instantiate (three, this.transform.position, Quaternion.identity);	
			activate = true;
		}
		if (MoodManager.mood == 4 && activate == false) {
			Instantiate (four, this.transform.position, Quaternion.identity);
			activate = true;
		}
		if (MoodManager.mood == 5 && activate == false) {
			Instantiate (five, this.transform.position, Quaternion.identity);
			activate = true;
		}
	}
}
