using UnityEngine;
using System.Collections;

public class InstructionsScene : MonoBehaviour
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void Execute()
    {
        Debug.Log("quitting application now");
        Application.LoadLevel("InstructionScene");
    }
}
