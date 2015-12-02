using UnityEngine;
using System.Collections;

public class QuitScene : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
       
        Application.Quit();
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}


    public void Execute()
    {
        Debug.Log("quitting application now");
        Application.Quit();
    }
}
