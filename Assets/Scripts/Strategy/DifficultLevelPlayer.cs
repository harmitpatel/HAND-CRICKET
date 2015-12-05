using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class DifficultLevelPlayer : MonoBehaviour, GameLevelStrategy
{


	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	
	
    public void StartGame()
    {
        Debug.Log("selected level is Difficult");
        Application.LoadLevel("LeapMotionDetectionScene");
    }
}
