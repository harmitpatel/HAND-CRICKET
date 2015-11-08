using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class Demo : MonoBehaviour {

	public Rect titleRect = new Rect();
	public Rect OKRect = new Rect();
	public Rect instructionsRect = new Rect();
	public Rect insRect = new Rect ();
		public string inst_text=string.Empty;
	public GUISkin m_demoSkin = new GUISkin();
	// Use this for initialization
	void Start () {
		OKRect.x = Screen.width / 2 - OKRect.width / 2;
		titleRect.x = Screen.width / 2 - titleRect.width / 2;
		insRect.x=Screen.width / 2 - insRect.width / 2;
		insRect.y=Screen.height / 2 - insRect.height / 2;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		GUI.skin = m_demoSkin;
		GUI.Label(titleRect,"INSTRUCTIONS",(GUIStyle)"instructionTitle");
		/*if(GUI.Label (titleRect, "Demo", (GUIStyle)"label"))
		{

		}*/
		GUI.Box (insRect, inst_text, (GUIStyle) "instructionText");
		if(GUI.Button (OKRect, "OK", (GUIStyle)"Buttons"))
		{
			Application.LoadLevel("StartScene");
		}
		//GUI.Label(instructionsRect,"INSTRUCTIONS",(GUIStyle)"ins");
		//(GUI.Label (instructionsRect, "INSTRUCTIONS", (GUIStyle)"label"))
		
	}


}
