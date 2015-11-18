using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[Serializable]
public class ValueHolder
{
	public Rect valueHolders = new Rect();
}

[ExecuteInEditMode]
public class TableManager : MonoBehaviour 
{
	public Rect mainRect = new Rect();
	public Rect TopBarRect = new Rect();
	public Rect LowerBoxRect = new Rect();

	public int m_boxWidth = 0;
	public int m_boxHeight = 0;

	public List<ValueHolder> m_PositionNoList = new List<ValueHolder> ();
	public List<ValueHolder> m_UsernameList = new List<ValueHolder> ();
	public List<ValueHolder> m_ScoreList = new List<ValueHolder> ();
	public List<ValueHolder> m_TimeList = new List<ValueHolder> ();

	public Rect PositionNoRect = new Rect();
	
	public Rect UsernameRect = new Rect();

	public Rect ScoreRect = new Rect ();

	public Rect TimeRect = new Rect ();

	public Rect OkButtonRect = new Rect ();

	public int m_tempWidth = 0;
	public int m_tempHeight = 0;

	public string user1 = string.Empty;
	public string user2 = string.Empty;
	public string user3 = string.Empty;
	public string user4 = string.Empty;
	public string user5 = string.Empty;

	public string score1 = string.Empty;
	public string score2 = string.Empty;
	public string score3 = string.Empty;
	public string score4 = string.Empty;
	public string score5 = string.Empty;

	public string time1 = string.Empty;
	public string time2 = string.Empty;
	public string time3 = string.Empty;
	public string time4 = string.Empty;
	public string time5 = string.Empty;
	public string url = "http://cmpe202.nagkumar.com/high_score/";


	public string resp = string.Empty;

	public IEnumerator GetUpdateFromServer()	{
		System.Collections.Generic.Dictionary<string,string> headers = new System.Collections.Generic.Dictionary<string,string>();
		headers.Add("Content-Type", "application/json");
		Debug.Log (headers);
		WWW www = new WWW (url, null, headers);

		resp = www.text;
		Debug.Log (resp);
		yield return www.text;
	}

	// Use this for initialization
	void Start ()     
	{

		mainRect.x = Screen.width / 2 - mainRect.width / 2;
		mainRect.y = Screen.height / 2 - mainRect.height / 2;



		PositionNoRect.width = UsernameRect.width = ScoreRect.width = TimeRect.width = m_tempWidth;
		PositionNoRect.height = UsernameRect.height = ScoreRect.height = TimeRect.height = m_tempHeight;


		m_PositionNoList [0].valueHolders.y = PositionNoRect.y + PositionNoRect.height;
		m_PositionNoList[0].valueHolders.width = m_tempWidth;
		m_PositionNoList[0].valueHolders.height = 50.0f;

		m_UsernameList[0].valueHolders.x = UsernameRect.x;
		m_UsernameList [0].valueHolders.y = UsernameRect.y + UsernameRect.height;
		m_UsernameList[0].valueHolders.width = m_tempWidth;
		m_UsernameList[0].valueHolders.height = 50.0f;

		m_ScoreList[0].valueHolders.x = ScoreRect.x;
		m_ScoreList [0].valueHolders.y = ScoreRect.y + ScoreRect.height;
		m_ScoreList[0].valueHolders.width = m_tempWidth;
		m_ScoreList[0].valueHolders.height = 50.0f;

		m_TimeList[0].valueHolders.x = TimeRect.x;
		m_TimeList [0].valueHolders.y = TimeRect.y + TimeRect.height;
		m_TimeList[0].valueHolders.width = m_tempWidth;
		m_TimeList[0].valueHolders.height = 50.0f;

		for (i = 1; i < 5; i++) 
		{
			m_PositionNoList[i].valueHolders.x = PositionNoRect.x;
			m_PositionNoList[i].valueHolders.y = m_PositionNoList[i-1].valueHolders.y + 50.0f;
			m_PositionNoList[i].valueHolders.width = m_tempWidth;
			m_PositionNoList[i].valueHolders.height = 50.0f;

			m_UsernameList[i].valueHolders.x = PositionNoRect.x + PositionNoRect.width;
			m_UsernameList[i].valueHolders.y = m_UsernameList[i-1].valueHolders.y + 50.0f;
			m_UsernameList[i].valueHolders.width = m_tempWidth;
			m_UsernameList[i].valueHolders.height = 50.0f;

			m_ScoreList[i].valueHolders.x = UsernameRect.x + UsernameRect.width;
			m_ScoreList [i].valueHolders.y = m_ScoreList[i-1].valueHolders.y + 50.0f;
			m_ScoreList[i].valueHolders.width = m_tempWidth;
			m_ScoreList[i].valueHolders.height = 50.0f;

			m_TimeList[i].valueHolders.x = ScoreRect.x + ScoreRect.width;
			m_TimeList [i].valueHolders.y = m_TimeList[i-1].valueHolders.y + 50.0f;
			m_TimeList[i].valueHolders.width = m_tempWidth;
			m_TimeList[i].valueHolders.height = 50.0f;
		}
		GetUpdateFromServer();

		UsernameRect.x = PositionNoRect.x + PositionNoRect.width;

		ScoreRect.x = UsernameRect.x + UsernameRect.width;

		TimeRect.x = ScoreRect.x + ScoreRect.width;



	}
	string[] users = {"HARMIT", "VEDANG", "NIPUN", "NAVJOT", "KRUTI"};
	int[] scores = {15, 25, 34, 43, 3};
    string[] finalResult = { "wins", "loses", "wins", "loses", "loses"};
	int i = 0;

	public GUISkin m_mainSkin = new GUISkin();

	void OnGUI()
	{
        GUI.skin = m_mainSkin;
		GUI.BeginGroup (mainRect, (GUIStyle)"");
		GUI.BeginGroup (TopBarRect, "LEADERBOARD",(GUIStyle)"leaderboardTitle");
		/*put your buttons here*/
		GUI.EndGroup ();
			GUI.BeginGroup (LowerBoxRect, (GUIStyle)"");
		GUI.Box (PositionNoRect, "Position No", (GUIStyle)"leaderboardElements");
		for (i = 0; i < 5; i++) 
        {
			GUI.Box (m_PositionNoList [i].valueHolders, (i + 1).ToString (), (GUIStyle)"leaderboardElements");
			GUI.Box (m_UsernameList [i].valueHolders, users [i], (GUIStyle)"leaderboardElements");
			GUI.Box (m_ScoreList [i].valueHolders, scores [i].ToString (), (GUIStyle)"leaderboardElements");
			GUI.Box (m_TimeList [i].valueHolders, finalResult[i], (GUIStyle)"leaderboardElements");
				
		}

		GUI.Box (UsernameRect, "Username", (GUIStyle)"leaderboardElements");
		GUI.Box (ScoreRect, "Batting Score", (GUIStyle)"leaderboardElements");
		GUI.Box (TimeRect, "Final Result", (GUIStyle)"leaderboardElements");
			GUI.EndGroup ();

		 if( GUI.Button(OkButtonRect, "OK", (GUIStyle)"Buttons"))
		{
			//Debug.Log("Clicked oK");
			Application.LoadLevel("StartScene");
		}

		GUI.EndGroup ();

	}   
}
