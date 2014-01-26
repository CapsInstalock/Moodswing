/* Contains the moods */
using UnityEngine;
using System.Collections;

public class MoodManager : MonoBehaviour {

	public static int mood;

	public Material basic;
	public Material angry;
	public Material excited;
	public Material fear;
	public Material sad;
	public Material tender;
	


	// Use this for initialization
	void Start () {
		mood = Riddle.riddleval;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
