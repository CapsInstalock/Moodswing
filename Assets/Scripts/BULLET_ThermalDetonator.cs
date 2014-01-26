using UnityEngine;
using System.Collections;

public class BULLET_ThermalDetonator : MonoBehaviour {
	
	float lifespan = 3.0f;
	public GameObject fireEffect;
	private RiddleCompare riddleCompare;

	void Awake () {

	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		lifespan -= Time.deltaTime;

		if (lifespan <= 0) {
			Explode ();
		}
	}
	
	void OnCollisionEnter(Collision collision) {
		


		if (collision.gameObject.tag == "Answer") 
		{
			riddleCompare = GetComponent<RiddleCompare>();
			collision.gameObject.tag = "Untagged";
			Destroy (collision.gameObject);
			Application.LoadLevel("Riddles");
			//MoodManager.mood = riddleCompare.moodVal;
		}

		else if(collision.gameObject.tag == "Enemy") {
			collision.gameObject.tag = "Untagged";
			Instantiate(fireEffect, collision.transform.position, Quaternion.identity);
			Application.LoadLevel("GameOver");
		}
	}
	
	void Explode() {
		Destroy(gameObject);
	}
}
