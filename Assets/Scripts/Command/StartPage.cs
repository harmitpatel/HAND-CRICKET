using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class StartPage : MonoBehaviour 
{
    [SerializeField]
	private Rect NewGameRect = new Rect();
    [SerializeField]
    private Rect DemoRect = new Rect();
    [SerializeField]
    private Rect LeaderBoardRect = new Rect();
    [SerializeField]
    private Rect QuitRect = new Rect();
    private SceneCommander m_sceneCommanderObj;

    [SerializeField]
    private GUISkin m_mainSkin = new GUISkin();


    public float floatTemp = 0.0f;
    int m_sceneNumber = 0;

	// Use this for initialization
	void Start () 
	{
        Positioner();

        m_sceneCommanderObj = gameObject.GetComponent<SceneCommander>();
	}

    private void Positioner()
    {
        NewGameRect.x = Screen.width / 2 - NewGameRect.width / 2;
        NewGameRect.y = Screen.height / 2 - NewGameRect.height / 2 - floatTemp;
        DemoRect.x = Screen.width / 2 - DemoRect.width / 2;
        DemoRect.y = NewGameRect.y + NewGameRect.height + 25.0f;
        LeaderBoardRect.x = Screen.width / 2 - LeaderBoardRect.width / 2;
        LeaderBoardRect.y = DemoRect.y + DemoRect.height + 25.0f;
        QuitRect.x = Screen.width / 2 - QuitRect.width / 2;
        QuitRect.y = LeaderBoardRect.y + LeaderBoardRect.height + 25.0f;
    }
	
	// Update is called once per frame
	void Update () 
	{

	}

	// all ur buttons and other stuff comes here..
	void OnGUI()
	{
		GUI.skin = m_mainSkin;

		//GUI.BeginGroup (OptionsRect, "", (GUIStyle)"label");

		if (GUI.Button (NewGameRect, "NEW GAME", (GUIStyle)"")) 
		{
            m_sceneNumber = 0;
            m_sceneCommanderObj.OpenScene(m_sceneNumber);
		}

		 else if (GUI.Button (DemoRect, "INSTRUCTIONS", (GUIStyle)"")) 
		{
            m_sceneNumber = 1;
            m_sceneCommanderObj.OpenScene(m_sceneNumber);
		}

		else if (GUI.Button (LeaderBoardRect, "HIGH SCORES", (GUIStyle)"")) 
		{
            m_sceneNumber = 2;
            m_sceneCommanderObj.OpenScene(m_sceneNumber);
		}

		else if (GUI.Button (QuitRect, "QUIT", (GUIStyle)"")) 
		{
            m_sceneNumber = 3;
            m_sceneCommanderObj.OpenScene(m_sceneNumber);
		}

		//GUI.EndGroup ();
	
	}
}