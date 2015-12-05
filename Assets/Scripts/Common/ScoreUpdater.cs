using UnityEngine;
using System.Collections;
using System;


[ExecuteInEditMode]
public class ScoreUpdater : MonoBehaviour 
{

    public Rect m_scoreDisplayer;
    public int m_score = 0;
    [SerializeField]
    private GUISkin m_mainSkin = new GUISkin();
    // Use this for initialization
	void Start ()
    {
        m_scoreDisplayer.x = Screen.width - m_scoreDisplayer.width - 30.0f;
        m_scoreDisplayer.y = Screen.height - m_scoreDisplayer.height - 30.0f;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
         GUI.skin = m_mainSkin;
         
        GUI.Box(m_scoreDisplayer, m_score.ToString(), (GUIStyle)"score");
    }


    public void SetScore(int a_scoreToBeAdded)
    {
        Debug.Log("adding to main score -- " + a_scoreToBeAdded);
        m_score += a_scoreToBeAdded;
    }
}
