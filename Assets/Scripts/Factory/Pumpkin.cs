using UnityEngine;
using System.Collections;
using System; 

public class Pumpkin : MonoBehaviour, Fruit
{
    [SerializeField]
    private int m_fruitHitScore;
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    public void ActivateFruit()
    {
        this.gameObject.SetActive(true);
        Debug.Log("activating fruit -- " + this.gameObject.name);
    }

    public void DeactivatedFruit()
    {
        this.gameObject.SetActive(false);
        Debug.Log("de-activating fruit -- " + this.gameObject.name);
    }

    public void UpdateScore(ScoreUpdater a_scoreUpdaterobj)
    {

        a_scoreUpdaterobj.SetScore(m_fruitHitScore);
    }
}
