using UnityEngine;
using System.Collections;
using System;


[ExecuteInEditMode]
public class GameOverDisplayer : MonoBehaviour 
{

    public Rect m_displayRect;
     [SerializeField]
    private GUISkin m_mainSkin ;
     public float speed = 0.0f;

	// Use this for initialization
	void Start () 
    {
        m_displayRect.x = -500.0f;
        m_displayRect.y = Screen.height / 2 - m_displayRect.height/ 2;
        m_displayRect.width = 0.0f;
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        //only for testing
        //remove before making build
        if (Input.GetKey(KeyCode.A))
        {
            DisplayGameOverMessage();
        }
	}

    public void DisplayGameOverMessage()
    {
        m_displayRect.x += speed * Time.deltaTime;
    }

    void OnGUI()
    {
        GUI.skin = m_mainSkin;
        GUI.Box(m_displayRect, "GAME OVERRR !!!", (GUIStyle)"gameOverObj");

    }
}
