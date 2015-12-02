using UnityEngine;
using System.Collections;
using System;

public class Apple : MonoBehaviour, Fruits
{
    [SerializeField]
    private  GameObject m_fruitObj;
    [SerializeField]
    private  Vector3 m_initialPosition = new Vector3(0, 0, 0);
    [SerializeField]
    private  int m_fruitPoints = 0;

    public  GameObject getFruitObject()
    {
        m_fruitObj = Instantiate(this.gameObject) as GameObject;
        Debug.Log("instantiating apple object");
        return m_fruitObj;
    }

    public  int getPoints()
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
	void Start () 
    {

       // m_fruitObj = gameObject.GetComponent<Apple>() as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
