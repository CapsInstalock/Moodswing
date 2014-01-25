/* Changes and Contains the moods */
using UnityEngine;
using System.Collections;

public class MoodManager : MonoBehaviour {

	public static int mood = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Tenderness")) //Configure in [Edit->Project Settings->Input]
			mood = 1;
		else if (Input.GetButtonDown("Sadness"))
			mood = 2;
		else if (Input.GetButtonDown("Anger"))
			mood = 3;
		else if (Input.GetButtonDown("Excitement"))
			mood = 4;
		else if (Input.GetButtonDown("Fear"))
			mood = 5;

		if (mood == 1)
			print ("Tender");
		else if (mood == 2)
			print ("Sad");
		else if (mood == 3)
			print ("Angry");
		else if (mood == 4)
			print ("Excitement");
		else if (mood == 5)
			print ("Fear");
	}
}
