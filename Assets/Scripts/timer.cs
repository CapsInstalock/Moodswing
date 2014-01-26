using UnityEngine; 
using System.Collections; 
public class timer : MonoBehaviour { 
	public float Seconds = 30; 
	public float Minutes = 0;
	// Use this for initialization 
	void Start () { } // Update is called once per frame
	void Update () {
		if(Seconds <=0) { Seconds = 30;
			if(Minutes >=1) {
				Minutes --; 
			} else {
				Minutes = 0; 
				Seconds = 0;
				// this makes the guitext show the time as X:XX para walng decimal
				GameObject.Find("TimerText").guiText.text = Minutes.ToString("f0") + ":0" + Seconds.ToString("f0");
			}
		} 
		else 
		{ 
			Seconds -= Time.deltaTime; 
		} // make sure na walang decimal
		if(Mathf.Round(Seconds) <=9) 
		{
			GameObject.Find("TimerText").guiText.text = Minutes.ToString("f0") + ":0" + Seconds.ToString("f0");
		} 
		else
		{ 
			GameObject.Find("TimerText").guiText.text = Minutes.ToString("f0") + ":" + Seconds.ToString("f0");
		} 
		if (Seconds <= 0) 
		{
			Debug.Log ("Game Over");
			Application.LoadLevel("GameOver");
		}
	} 
}
