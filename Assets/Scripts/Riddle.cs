using UnityEngine;
using System.Collections;

public class Riddle : MonoBehaviour {

	public static int riddleval;

	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}

	// Use this for initialization
	void Start () {
		riddleval = Random.Range (1, 5);
		Debug.Log (riddleval);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
