using UnityEngine;
using System.Collections;
[ExecuteInEditMode]
public class gameOptions : MonoBehaviour {
	public Rect newRect = new Rect();
	//public Rect resumeRect = new Rect();
	public Rect optionsRect = new Rect();
	public Rect quitRect = new Rect();

	// Use this for initialization
	void Start () {
		newRect.x = Screen.width / 2 - newRect.width / 2;
		//newRect.y = Screen.height  - newRect.height;

		optionsRect.x = Screen.width / 2 - optionsRect.width / 2;
		//optionsRect.y = (Screen.height  - optionsRect.height);

		quitRect.x = Screen.width / 2 - quitRect.width / 2;
		//quitRect.y = Screen.height  - quitRect.height;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		if(GUI.Button (newRect, "NEW GAME", (GUIStyle)"button")) 
		{
			Application.LoadLevel("");
		}
		/*if(GUI.Button (resumeRect, "RESUME GAME", (GUIStyle)"button"))
		{

		}*/
		if(GUI.Button (optionsRect, "OPTIONS", (GUIStyle)"button"))
		{
			Application.LoadLevel("GameOptionsScene");
		}
		if(GUI.Button (quitRect, "QUIT", (GUIStyle)"button"))
		{
			Application.LoadLevel("StartScene");
			Application.Quit();
		}


	}
}
