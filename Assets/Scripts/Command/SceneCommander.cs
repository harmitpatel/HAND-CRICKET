using UnityEngine;
using System.Collections;
using System;

public interface CommandsHolder
{
  void OpenScene(int a_SceneNumber);
}


public class SceneCommander : MonoBehaviour, CommandsHolder 
{
    [SerializeField]
    private NewGameScene m_newGameSceneObj;

    [SerializeField]
    private InstructionsScene m_instructionSceneObj;

    [SerializeField]
    private HighScoreScene m_highScoreSceneObj;

    [SerializeField]
    private QuitScene m_quitSceneObj;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}


    public void OpenScene(int a_sceneNumber)
    {
        switch (a_sceneNumber)
        {
            case 0:
                Debug.Log("############### new scene nameinputscene");
                m_newGameSceneObj.Execute();
                break;

            case 1:
                 Debug.Log("############### new scene nameinputscene");
                 m_instructionSceneObj.Execute();
                break;

            case 2:
                 Debug.Log("############### new scene nameinputscene");
                 m_highScoreSceneObj.Execute();
                break;

            case 3:
                 Debug.Log("############### new scene nameinputscene");
                 m_quitSceneObj.Execute();
                break;
        }
    }

}
