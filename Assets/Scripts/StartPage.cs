using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class StartPage : MonoBehaviour {

	public Rect OptionsRect = new Rect();
	public Rect NewGameRect = new Rect();
	public Rect DemoRect = new Rect();
	public Rect LeaderBoardRect = new Rect();
	public Rect QuitRect = new Rect();

	public GUISkin m_mainSkin = new GUISkin();

	// Use this for initialization
	void Start () 
	{
		//NewGameRect.width = DemoRect.width = LeaderBoardRect.width = QuitRect.width = OptionsRect.width;
		//NewGameRect.x = OptionsRect.width / 2 - NewGameRect.width / 2;
		//DemoRect.x = OptionsRect.width / 2 - DemoRect.width / 2;
		//LeaderBoardRect.x = OptionsRect.width / 2 - LeaderBoardRect.width / 2;
		//QuitRect.x = OptionsRect.width / 2 - QuitRect.width / 2;

	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	// all ur buttons and other stuff comes here..
	void OnGUI()
	{
		GUI.skin = m_mainSkin;

		GUI.BeginGroup (OptionsRect, "", (GUIStyle)"label");

		if (GUI.Button (NewGameRect, "NEW GAME", (GUIStyle)"Buttons")) 
		{
            Application.LoadLevel("OptionScene");
		}



		if (GUI.Button (DemoRect, "INSTRUCTIONS", (GUIStyle)"Buttons")) 
		{
            Application.LoadLevel("InstructionScene");
		}

		if (GUI.Button (LeaderBoardRect, "HIGH SCORES", (GUIStyle)"Buttons")) 
		{
            Application.LoadLevel("HighScoreScene");
		}

		if (GUI.Button (QuitRect, "QUIT", (GUIStyle)"Buttons")) 
		{
            Application.Quit();
		}

		GUI.EndGroup ();
	
	}
}