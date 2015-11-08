using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class AnimationDisplay : MonoBehaviour 
{
	public Rect m_boundaryRect = new Rect();
	public Rect m_scissorRect = new Rect();
	public Rect m_stoneRect = new Rect();
	public Rect m_paperRect = new Rect();

	public bool m_scissorReachedLeft = false;
	public bool m_paperReachedLeft = false;
	public bool m_stoneReachedLeft = false;

	public float m_scissorSpeed = 0.0f;
	public float m_paperSpeed = 0.0f;
	public float m_stoneSpeed = 0.0f;

	// Use this for initialization
	void Start () 
	{
		m_scissorReachedLeft = false;

		m_boundaryRect.x = Screen.width - m_boundaryRect.width;
		m_boundaryRect.y = Screen.height / 2 - m_boundaryRect.height / 2;

		m_scissorRect.x = m_boundaryRect.width;
		//m_scissorRect.y = 0.0f;

		m_paperRect.x = m_boundaryRect.width;
		//m_paperRect.y = m_boundaryRect.height / 3.0f;

		m_stoneRect.x = m_boundaryRect.width;
		//m_stoneRect.y = m_boundaryRect.height * (2.0f/3.0f);

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (m_scissorRect.x >= m_boundaryRect.width) 
		{
			m_scissorReachedLeft = false;
		}

		if (m_paperRect.x >= m_boundaryRect.width) 
		{
			m_paperReachedLeft = false;
		}

		if (m_stoneRect.x >= m_boundaryRect.width) 
		{
			m_stoneReachedLeft = false;
		}


		if (m_scissorRect.x <= 0.0f) 
		{
			m_scissorReachedLeft = true;
		}

		if (m_stoneRect.x <= 0.0f) 
		{
			m_stoneReachedLeft = true;
		}

		if (m_paperRect.x <= 0.0f) 
		{
			m_paperReachedLeft = true;
		}

		if (!m_scissorReachedLeft)
		{
			MoveScissorLeft();
		}

		if (!m_paperReachedLeft)
		{
			MovePaperLeft();
		}

		if (!m_stoneReachedLeft)
		{
			MoveStoneLeft();
		}

		if (m_scissorReachedLeft) 
		{
			MoveScissorRight();
		}

		if (m_paperReachedLeft) 
		{
			MovePaperRight();
		}

		if (m_stoneReachedLeft) 
		{
			MoveStoneRight();
		}


	}


	public GUISkin m_mainSkin = new GUISkin();
	void OnGUI()
	{
		GUI.skin = m_mainSkin;

		GUI.BeginGroup (m_boundaryRect, "", (GUIStyle)"");
			GUI.Box (m_scissorRect, "", (GUIStyle)"scissorHand");
		GUI.Box (m_paperRect, "", (GUIStyle)"paperHand");
			GUI.Box (m_stoneRect, "", (GUIStyle)"rockHand");
		GUI.EndGroup ();
	}

	void MoveScissorLeft()
	{	
		m_scissorRect.x -= m_scissorSpeed * Time.deltaTime;
	}

	void MovePaperLeft()
	{	
		m_paperRect.x -= m_paperSpeed * Time.deltaTime;
	}

	void MoveStoneLeft()
	{	
		m_stoneRect.x -= m_stoneSpeed * Time.deltaTime;
	}

	void MoveScissorRight()
	{	
		m_scissorRect.x += m_scissorSpeed * Time.deltaTime;
	}
	
	void MovePaperRight()
	{	
		m_paperRect.x += m_paperSpeed * Time.deltaTime;
	}
	
	void MoveStoneRight()
	{	
		m_stoneRect.x += m_stoneSpeed * Time.deltaTime;
	}
	
}
