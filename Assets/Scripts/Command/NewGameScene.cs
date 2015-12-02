using UnityEngine;
using System.Collections;

public class NewGameScene : MonoBehaviour
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Execute() 
    {
        Debug.Log("opening new scene now");
        Application.LoadLevel("NameInputScene");
    }
}
