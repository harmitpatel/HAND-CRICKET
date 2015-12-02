using UnityEngine;
using System.Collections;
using System;

[ExecuteInEditMode]
public class PlayerNameInputTaker : MonoBehaviour
{
    [SerializeField]
    private Rect m_nameTextRect = new Rect();
    [SerializeField]
    private Rect m_nameInputRect = new Rect();
    [SerializeField]
    private Rect m_emailTextRect = new Rect();
    [SerializeField]
    private Rect m_emailInputRect = new Rect();
    [SerializeField]
    private Rect m_registrationInputRect = new Rect();
    [SerializeField]
    private Rect SelectLevelRect = new Rect();
    public string m_sInputName = string.Empty;
    public string m_sInputEmail = string.Empty;
    public bool m_bToggleValue = false;
    [SerializeField]
    private string m_sRegistrationText = string.Empty;
    [SerializeField]
    private GUISkin m_mainSkin = new GUISkin();
   

	// Use this for initialization
	void Start () 
    {
        
        m_nameInputRect.x = Screen.width / 2 - m_nameInputRect.width / 2;
        m_nameInputRect.y = Screen.height / 2 - m_nameInputRect.height / 2 - 20.0f;
        m_nameTextRect.x = m_nameInputRect.x - m_nameTextRect.width - 10.0f;
        m_nameTextRect.y = m_nameInputRect.y;
        m_emailInputRect.x = Screen.width / 2 - m_emailInputRect.width / 2;
        m_emailInputRect.y = m_nameInputRect.y + m_nameInputRect.height + 20.0f;
        m_emailTextRect.x = m_emailInputRect.x - m_emailTextRect.width - 10.0f;
        m_emailTextRect.y = m_emailInputRect.y;
        m_registrationInputRect.x = Screen.width / 2 - m_registrationInputRect.width / 2;
        m_registrationInputRect.y = m_emailInputRect.y + m_emailInputRect.height + 20.0f;
        
        SelectLevelRect.x = Screen.width / 2 - SelectLevelRect.width / 2;
        SelectLevelRect.y = m_registrationInputRect.y + m_registrationInputRect.height + 20.0f;
    }
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    
    void OnGUI()
    {
        GUI.skin = m_mainSkin;
        GUI.Box(m_nameTextRect, "Enter your name", (GUIStyle)"box");
        GUI.Box(m_emailTextRect, "Enter your email", (GUIStyle) "box");
        m_sInputName = GUI.TextField(m_nameInputRect, m_sInputName, (GUIStyle) "TextField");
        m_sInputEmail = GUI.TextField(m_emailInputRect, m_sInputEmail, (GUIStyle)"TextField");
        m_bToggleValue = GUI.Toggle(m_registrationInputRect, m_bToggleValue, m_sRegistrationText, (GUIStyle) "Toggle");
        if (m_sInputName == string.Empty || m_sInputEmail == string.Empty)
        {
            if (GUI.Button(SelectLevelRect, "Enter Details Above", (GUIStyle)"Buttons")) ;
        }
        else
        {
            if (GUI.Button(SelectLevelRect, "Go Go Go!!!", (GUIStyle)"Buttons"))
            {
                Application.LoadLevel("LevelSelectionScene");

            }
        }
            
       
 
    }
}
