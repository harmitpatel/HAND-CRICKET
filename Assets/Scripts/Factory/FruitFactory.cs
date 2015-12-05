using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;


public interface Fruit
{
    void ActivateFruit();
    void DeactivatedFruit();
}

[Serializable]
public class FruitInfo
{
    public GameObject m_FruitItem;
    public Vector3 m_fruitPosition;
    public float m_speedOfFruit = 0.0f;
    public int m_fruitHitScore = 0;
    public int m_fruitID = 0;
}

public class FruitFactory : MonoBehaviour
{
    [SerializeField]
     List<FruitInfo> m_ListOfFruitPositions = new List<FruitInfo>();

    [SerializeField]
     Banana m_banaObj;

    [SerializeField]
     Kiwi m_kiwiObj;

    [SerializeField]
     Pumpkin m_pumpkinObj;

    [SerializeField]
     DynamiteAdapter m_dynamiteAdapterObj;

    [SerializeField] 
    float m_currentTime = 0.0f;

    [SerializeField]
    float m_maxFruitTImeInGame = 0.0f;
        
    [SerializeField]
     int m_RandomPositionNumber = 0;

    [SerializeField]
     bool m_isAnyFoodCreated = false;


    // Use this for initialization
    void Start()
    {
        //setting all fruits false initially
        OnStartFruitDeActivator();
       //m_RandomPositionNumber = UnityEngine.Random.Range(0,2);
    }

    private void OnStartFruitDeActivator()
    {
        for (int i = 0; i < m_ListOfFruitPositions.Count; i++)
        {
            m_ListOfFruitPositions[i].m_FruitItem.SetActive(false);
            m_ListOfFruitPositions[i].m_fruitPosition = m_ListOfFruitPositions[i].m_FruitItem.gameObject.transform.position;
            m_ListOfFruitPositions[i].m_fruitID = i;
            m_isAnyFoodCreated = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //initially all fruits are deactive
        //hence this loop will always run first
        //once this loop runs, below boolean will become true
        // and then the code for fruit movement and fruit deactivation follows
        if (!m_isAnyFoodCreated)
        {
            m_RandomPositionNumber = UnityEngine.Random.Range(0, (m_ListOfFruitPositions.Count));
            //m_ListOfFruitPositions[m_RandomPositionNumber].m_fruitPosition = m_ListOfFruitPositions[m_RandomPositionNumber].m_FruitItem.gameObject.transform.position;
            Debug.Log("random number generated is --- " + m_RandomPositionNumber);
            RandomFruitActivation(m_RandomPositionNumber);
            //m_ListOfFruitPositions[m_RandomPositionNumber].m_FruitItem.SetActive(true);
            m_currentTime = Time.time;
        }


        //code for movement from top to bottom
        //if particular fruit is active then move it from top  to bottom
        FruitMovement();

        if (m_isAnyFoodCreated)
        {
            if ((Time.time - m_currentTime) >= m_maxFruitTImeInGame)
            {
                //m_ListOfFruitPositions[m_RandomPositionNumber].m_FruitItem.SetActive(false);
                RandomFruitDeActivation(m_RandomPositionNumber);
                m_isAnyFoodCreated = false;
            }
        }
    }

    private void RandomFruitActivation(int a_randomFruitNumber)
    {
        switch (a_randomFruitNumber)
        {
            case 0:
                m_banaObj.ActivateFruit();
                break;
            case 1:
                m_pumpkinObj.ActivateFruit();
                break;
            case 2:
                m_kiwiObj.ActivateFruit();
                break;
            case 3:
                m_dynamiteAdapterObj.ActivateFruit();
                break;
        }
    }



    private void FruitMovement()
    {
        for (int i = 0; i < m_ListOfFruitPositions.Count; i++)
        {
            if (m_ListOfFruitPositions[i].m_FruitItem.activeSelf)
            {
                m_ListOfFruitPositions[i].m_fruitPosition.y -= m_ListOfFruitPositions[i].m_speedOfFruit + Time.deltaTime;
                m_ListOfFruitPositions[i].m_FruitItem.gameObject.transform.position = m_ListOfFruitPositions[i].m_fruitPosition;
                m_isAnyFoodCreated = true;
            }

            else
            {
                m_ListOfFruitPositions[i].m_fruitPosition.y = 4.0f;
                m_ListOfFruitPositions[i].m_FruitItem.gameObject.transform.position = m_ListOfFruitPositions[i].m_fruitPosition;
            }
        }
    }

    private void RandomFruitDeActivation(int a_randomFruitNumber)
    {
        switch (a_randomFruitNumber)
        {
            case 0:
                m_banaObj.DeactivatedFruit();
                break;
            case 1:
                m_pumpkinObj.DeactivatedFruit();
                break;
            case 2:
                m_kiwiObj.DeactivatedFruit();
                break;
            case 3:
                m_dynamiteAdapterObj.DeactivatedFruit();
                break;
        }
    }

   

    
}