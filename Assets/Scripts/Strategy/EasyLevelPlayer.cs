using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class EasyLevelPlayer : MonoBehaviour, GameLevelStrategy
{


	// Use this for initialization
	void Start () 
    {
		
       
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
    {
       
	}

    public void StartGame()
    {
        Debug.Log("selected level is EASY");
        Application.LoadLevel("LeapMotionDetectionScene");
    }
}