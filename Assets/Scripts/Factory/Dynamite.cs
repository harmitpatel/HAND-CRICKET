using UnityEngine;
using System.Collections;
using System;


public interface ExplodeFruit
{
    void Activate();
    void EndGame();
}

public class Dynamite : MonoBehaviour,  ExplodeFruit
{
    [SerializeField]
    private  GameOverDisplayer m_gameOverDisplayerObj;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    

    public void Activate()
    {
        this.gameObject.SetActive(true);
        Debug.Log("activating fruit -- " + this.gameObject.name);
    }

    public void EndGame()
    {
        this.gameObject.SetActive(false);
        m_gameOverDisplayerObj.DisplayGameOverMessage();
    }
}
