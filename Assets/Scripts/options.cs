using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class options : MonoBehaviour {

	public Rect demoRect = new Rect();
	public Rect soundRect = new Rect();
	public Rect scoreRect = new Rect();
	public Rect okRect = new Rect();

	// Use this for initialization
	void Start () {
		demoRect.x = Screen.width / 2 - demoRect.width / 2;
		soundRect.x = Screen.width / 2 - soundRect.width / 2;
		scoreRect.x = Screen.width / 2 - scoreRect.width / 2;
		okRect.x = Screen.width / 2 - okRect.width / 2;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		if(GUI.Button (demoRect, "DEMO", (GUIStyle)"button")) 
		{
			Application.LoadLevel("DemoScene");
		}
		//---- commented as not sure if volume button should be there or not
		//if(GUI.Button (soundRect, "SOUND", (GUIStyle)"button"))
		//{
		//	
		//}
		if(GUI.Button (scoreRect, "LEADERBOARD", (GUIStyle)"button"))
		{
			Application.LoadLevel("leaderBoard");

		}
		if(GUI.Button (okRect, "OK", (GUIStyle)"button"))
		{
			Application.LoadLevel("OptionScene");
		}
	}
}
