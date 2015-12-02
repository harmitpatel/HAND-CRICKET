using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class LevelSelector : MonoBehaviour {

    [SerializeField]
	private Rect EasyLevelSelectorRect = new Rect();
    [SerializeField]
    private Rect DifficultLevelSelectorRect = new Rect();
    [SerializeField]
    private Rect OkRect = new Rect();
    [SerializeField]
    private float m_RectangleWidth = 0.0f;
    [SerializeField]
    private float m_RectangleHeight = 0.0f;

    [SerializeField]
    private GUISkin m_mainSkin = new GUISkin();

	// Use this for initialization
	void Start () 
    {
		EasyLevelSelectorRect.x = Screen.width / 2 - EasyLevelSelectorRect.width / 2;
        EasyLevelSelectorRect.y = Screen.height / 2 - EasyLevelSelectorRect.height / 2;
		DifficultLevelSelectorRect.x = Screen.width / 2 - DifficultLevelSelectorRect.width / 2;
        DifficultLevelSelectorRect.y = EasyLevelSelectorRect.y + m_RectangleHeight;
		OkRect.x = Screen.width / 2 - OkRect.width / 2;
        OkRect.y = DifficultLevelSelectorRect.y + m_RectangleHeight;


        EasyLevelSelectorRect.width = DifficultLevelSelectorRect.width = OkRect.width = m_RectangleWidth;
        EasyLevelSelectorRect.height = DifficultLevelSelectorRect.height = OkRect.height = m_RectangleHeight;
       
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
    {
        GUI.skin = m_mainSkin;

		if(GUI.Button (EasyLevelSelectorRect, "EASY ", (GUIStyle)"Buttons")) 
		{
            //Debug.Log("selected level is EASY");
            Application.LoadLevel("LeapMotionDetectionScene");
		}

        else if (GUI.Button(DifficultLevelSelectorRect, "DIFFICULT", (GUIStyle)"Buttons"))
        {
            //Debug.Log("selected level is DIFFICULT");
            Application.LoadLevel("LeapMotionDetectionScene");
        }
	}
}