using UnityEngine;
using System.Collections;
using System;

public class Bomb: MonoBehaviour, Fruits 
{
    [SerializeField]
    private GameObject m_fruitObj;
    [SerializeField]
    private Vector3 m_initialPosition = new Vector3(0, 0, 0);
    [SerializeField]
    private int m_fruitPoints = 0;

    Bomb(GameObject m_fruitObj, int m_fruitPoint)
    {
        this.m_fruitObj = m_fruitObj;
        this.m_fruitPoints = m_fruitPoint;
    }

    public GameObject getFruitObject()
    {
        m_fruitObj = Instantiate(this.gameObject) as GameObject;
        Debug.Log("instantiating bomb object");
        return null;
    }

    public int getPoints()
    {
        return m_fruitPoints;
    }

    public void setInitialPosition()
    {

    }
    public Vector3 getInitialPosition()
    {
        return m_initialPosition;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
