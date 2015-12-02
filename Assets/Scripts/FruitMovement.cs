using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;


public interface Fruits 
{
        //setID
    //Movement with specific speed
    //SetPoint
     GameObject getFruitObject();
     int getPoints();
     void setInitialPosition();
     Vector3 getInitialPosition();
        
}



[ExecuteInEditMode]
public class FruitMovement : MonoBehaviour 
{

  
	[SerializeField]
	bool m_isDebug = false;

	public List<Fruits> m_fruitTypeList = new List<Fruits>();

    [SerializeField]
    private FruitFactory fruitFactory;

	[SerializeField]
	private List<GameObject> m_FruitList ;
    
	[SerializeField]
	int m_randomFruitNumber = 0;

	[SerializeField]
	float m_EnemyBirthTime = 0.0f;

	GameObject m_tempFruit;
	// Use this for initialization
	void Start () 
	{

		m_FruitList.Clear ();

		/*for(int l_enemyIndex = 0; l_enemyIndex < m_EnemyTypeList.Count; l_enemyIndex++)
		{
			m_EnemyTypeList[l_enemyIndex].m_fruitID = l_enemyIndex;
        }*/

        
		for(int j = 0; j < 50; j++)
		{
            m_randomFruitNumber = UnityEngine.Random.Range(0, 3);
            Debug.Log("generated fruit at random number ----------- " + m_randomFruitNumber);
            m_tempFruit = fruitFactory.createFruit(m_randomFruitNumber);
           //m_tempFruit = Instantiate(m_EnemyTypeList[m_randomEnemyNumber].m_fruitObj) as GameObject;
			m_FruitList.Add(m_tempFruit);
            m_FruitList[j].SetActive(false);
           
		}

        StartCoroutine(FruitBirth());
	}


    IEnumerator FruitBirth()
    {
        for (int l_activeFruitIndex = 0; l_activeFruitIndex < 50; l_activeFruitIndex++)
        {
           yield return new WaitForSeconds(2);
           m_FruitList[l_activeFruitIndex].SetActive(true);
           if(m_FruitList[l_activeFruitIndex].activeSelf)
           {
                Debug.Log("activating fruit -- " + m_FruitList[l_activeFruitIndex].name);
           }
         }
    }

    // Update is called once per frame
	void Update () 
	{
        //Debug.Log("dfghjkl");
        
        
		//enemy deletion testing code
//		if (Input.GetKeyDown (KeyCode.A)) 
//		{
//			m_InGameEnemies.RemoveAt(2);
//			for(int l_inGameEnemyIndex = 0; l_inGameEnemyIndex < m_InGameEnemies.Count; l_inGameEnemyIndex++)
//			{
//				if(!m_InGameEnemies[l_inGameEnemyIndex].activeSelf)
//				{
//					Debug.Log ("Not active at number ==  " + m_InGameEnemies[l_inGameEnemyIndex]);
//				}
//			}
//		}
	}
}