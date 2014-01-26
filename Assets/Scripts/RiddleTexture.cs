using UnityEngine;
using System.Collections;

public class RiddleTexture : MonoBehaviour {

	public Material  Riddle1; 
	public Material  Riddle2; 
	public Material  Riddle3; 
	public Material  Riddle4; 
	public Material  Riddle5; 
	private Riddle riddle; 

	private float Seconds = 5; 
	private float Minutes = 0; 
	// Use this for initialization
	void Start () {
		riddle = GetComponent<Riddle>();


	}
	
	// Update is called once per frame
	void Update () {
		if (Riddle.riddleval == 1){
			//Display texture
			this.renderer.material = Riddle1;
		}
		if (Riddle.riddleval== 2) {
			//Display texture
			this.renderer.material = Riddle2;
		}
		if (Riddle.riddleval == 3) {
			//Display texture
			this.renderer.material = Riddle3;
		}
		if (Riddle.riddleval == 4) {
			//Display texture"
			this.renderer.material = Riddle4;
		}
		if (Riddle.riddleval == 5) {
			//Display texture
			this.renderer.material = Riddle5;
		}
		if(Seconds <=0) 
		{ 
			Seconds = 5;
			if(Minutes >=1) {
				Minutes --; 
			} 
			else 
			{
				Minutes = 0; 
				Seconds = 0;
				// this makes the guitext show the time as X:XX para walng decimal
				//GameObject.Find("TimerText").guiText.text = Minutes.ToString("f0") + ":0" + Seconds.ToString("f0");
			}
		} 
		else 
		{ 
			Seconds -= Time.deltaTime; 
		} 
		
		if (Seconds <= 0) 
		{
			Application.LoadLevel("level01");
		}
	}
}
