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
        m_nameTextRect.x = Screen.width/2 - m_nameTextRect.width/2;

        m_nameInputRect.x = Screen.width / 2 - m_nameInputRect.width / 2;
        m_nameInputRect.y = m_nameTextRect.y + m_nameTextRect.height + 20.0f;


        m_emailTextRect.x = Screen.width / 2 - m_emailTextRect.width / 2; ;
        m_emailInputRect.x = Screen.width / 2 - m_emailInputRect.width / 2;
        m_emailInputRect.y = m_emailTextRect.y + m_emailTextRect.height + 20.0f;
        
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
        GUI.Box(m_nameTextRect, "Name Please", (GUIStyle)"textstyle");
        GUI.Box(m_emailTextRect, "Email Id Please", (GUIStyle)"textstyle");
        m_sInputName = GUI.TextField(m_nameInputRect, m_sInputName, (GUIStyle)"ins");
        m_sInputEmail = GUI.TextField(m_emailInputRect, m_sInputEmail, (GUIStyle)"ins");
        m_bToggleValue = GUI.Toggle(m_registrationInputRect, m_bToggleValue, m_sRegistrationText, (GUIStyle)"Toggle");
        if (m_sInputName == string.Empty || m_sInputEmail == string.Empty)
        {
            if (GUI.Button(SelectLevelRect, "Enter Details Above", (GUIStyle)"")) ;
        }
        else
        {
            if (GUI.Button(SelectLevelRect, "Go Go Go!!!", (GUIStyle)""))
            {
                Application.LoadLevel("LevelSelectionScene");

            }
        }
            
       
 
    }
}
