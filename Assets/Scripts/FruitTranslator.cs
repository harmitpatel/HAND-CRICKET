using UnityEngine;
using System.Collections;
using System;

[ExecuteInEditMode]
public class FruitTranslator : MonoBehaviour
{
	[SerializeField]
	private GameObject m_fruitObject;

	[SerializeField]
	private Vector3 m_scenePosition = Vector3.zero;

	[SerializeField]
	private float m_speedOfEnemy = 0.0f;

	// Use this for initialization
	void Start () 
	{
		//m_enemyObject.SetActive(true);
		//m_scenePosition = m_fruitObject.gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		/*if (m_fruitObject.activeSelf) 
		{
			m_scenePosition.y += m_speedOfEnemy *  Time.deltaTime;
			m_fruitObject.gameObject.transform.position = m_scenePosition;
		}*/
	}

	void OnTriggerEnter(Collider other)
	{
		/*if (other.CompareTag ("House")) 
		{
			Debug.Log("Enemy " + m_fruitObject.name + " hit the house");
			m_fruitObject.SetActive(false);
		}*/
	}
}