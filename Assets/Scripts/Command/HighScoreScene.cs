using UnityEngine;
using System.Collections;

public class HighScoreScene : MonoBehaviour
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Execute()
    {
        Debug.Log("high score scene now");
        Application.LoadLevel("HighScoreScene");
    }

}
