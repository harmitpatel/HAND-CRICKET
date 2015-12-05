using UnityEngine;
using System.Collections;

public class DynamiteAdapter : MonoBehaviour, Fruit
{
    [SerializeField]
    Dynamite m_dynamiteObj;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ActivateFruit()
    {
        m_dynamiteObj.Activate();
    }

    public void DeactivatedFruit()
    {
        m_dynamiteObj.EndGame();
        Debug.Log("de-activating fruit -- " + this.gameObject.name);
    }
}
