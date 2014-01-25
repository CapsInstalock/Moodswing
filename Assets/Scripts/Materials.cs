using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Materials : MonoBehaviour {

	public Material basic;
	public Material angry;
	public Material excited;
	public Material fear;
	public Material sad;
	public Material tender;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (MoodManager.mood == 0) {
			this.renderer.material = basic;
		}
		if (MoodManager.mood == 1) { // References "mood" from MoodManager.cs
			this.renderer.material = tender;
		}
		if (MoodManager.mood == 2) {
			this.renderer.material = sad;
		}
		if (MoodManager.mood == 3) {
			this.renderer.material = angry;
		}
		if (MoodManager.mood == 4) {
			this.renderer.material = excited;
		}
		if (MoodManager.mood == 5) {
			this.renderer.material = fear;
		}
	}
}
