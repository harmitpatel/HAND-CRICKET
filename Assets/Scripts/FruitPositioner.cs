using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

[Serializable]
public class FruitPositionSetter
{
    public GameObject m_FruitItem;
    public Vector3 m_fruitPosition;
    public float m_speedOfFruit = 0.0f;
    //public int m_FruitPositionNumber = 0;
    //public bool m_isFoodSet = false;
    //public bool m_isFoodGrabbed = false;
    //public int m_FoodEatenCount = 0;
}

public class FruitPositioner : MonoBehaviour
{
    [SerializeField]
    private List<FruitPositionSetter> m_ListOfFruitPositions = new List<FruitPositionSetter>();

    [SerializeField] 
    float m_currentTime = 0.0f;
        
    [SerializeField]
    private int m_RandomPositionNumber = 0;

    [SerializeField]
    private bool m_isAnyFoodCreated = false;

    public bool m_IsGrabbedFood = false;



    // Use this for initialization
    void Start()
    {
        //setting all false initially
        for (int i = 0; i < m_ListOfFruitPositions.Count; i++)
        {
            m_ListOfFruitPositions[i].m_FruitItem.SetActive(false);
            m_ListOfFruitPositions[i].m_fruitPosition = m_ListOfFruitPositions[i].m_FruitItem.gameObject.transform.position;
            //Debug.Log ("Setting all to false before start");
        }

        m_RandomPositionNumber = UnityEngine.Random.Range(0,2);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown (KeyCode.G)) 
        {
            if (!m_isAnyFoodCreated)
            {
                m_RandomPositionNumber = UnityEngine.Random.Range(0, (m_ListOfFruitPositions.Count));
                m_ListOfFruitPositions[m_RandomPositionNumber].m_fruitPosition = m_ListOfFruitPositions[m_RandomPositionNumber].m_FruitItem.gameObject.transform.position;
                Debug.Log("random number generated is --- " + m_RandomPositionNumber);
                m_ListOfFruitPositions[m_RandomPositionNumber].m_FruitItem.SetActive(true);
                
                //m_ListOfFruitPositions[m_RandomPositionNumber].m_FoodEatenCount++;
                //m_ListOfFruitPositions[m_RandomPositionNumber].m_isFoodSet = true;
                m_currentTime = Time.time;
                //Debug.Log("time at which made visible --- " + m_currentTime);
                //Debug.Log("visible GO -- " + m_ListOfFoodPositions[m_RandomPositionNumber].m_FoodItem.name);
            }
        }

        for (int i = 0; i < m_ListOfFruitPositions.Count; i++)
        {
            if (m_ListOfFruitPositions[i].m_FruitItem.activeSelf)
            {
                m_ListOfFruitPositions[i].m_fruitPosition.y -= m_ListOfFruitPositions[i].m_speedOfFruit + Time.deltaTime;
                m_ListOfFruitPositions[i].m_FruitItem.gameObject.transform.position = m_ListOfFruitPositions[i].m_fruitPosition;
                //m_ListOfFruitPositions[i].m_FruitItem.gameObject.transform.position = m_ListOfFruitPositions[i].m_fruitPosition;
                m_isAnyFoodCreated = true;
            }
            else
            {
                m_ListOfFruitPositions[i].m_fruitPosition.y = 4.0f;
                m_ListOfFruitPositions[i].m_FruitItem.gameObject.transform.position = m_ListOfFruitPositions[i].m_fruitPosition;
               // m_ListOfFruitPositions[i].m_FruitItem.gameObject.transform.position = m_ListOfFruitPositions[i].m_fruitPosition;
            }

           
        }

        if (m_isAnyFoodCreated)
        {
            if ((Time.time - m_currentTime) >= 1.0f)
            {
                m_ListOfFruitPositions[m_RandomPositionNumber].m_FruitItem.SetActive(false);
                
                //m_ListOfFruitPositions[m_RandomPositionNumber].m_isFoodSet = false;
                //Debug.Log("Setting false -- " + m_ListOfFoodPositions[m_RandomPositionNumber].m_FoodItem.name);
                m_isAnyFoodCreated = false;
            }
        }


    }
}