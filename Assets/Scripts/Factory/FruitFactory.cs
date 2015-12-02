using UnityEngine;
using System.Collections;
using System;

public class FruitFactory : MonoBehaviour {
    public Apple appleObject = null;
    public WaterMelon watermelonObject = null;
    public Banana bananaObject = null;
    public Bomb bombObject = null;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    
    public GameObject createFruit(int a_randomInput)
    {

        GameObject tempObject = null;
        
        switch (a_randomInput)
        {
            case 0:
                appleObject = this.gameObject.GetComponent<Apple>();
                if (appleObject != null)
                {
                    Debug.Log("apple object is ------- " + appleObject);
                    tempObject = appleObject.getFruitObject();
                    Debug.Log("temp object is ------- " + tempObject);
                }

                else
                {
                    Debug.Log("apple object is ------- " + appleObject);
                }
                
                break;
            case 1:
                watermelonObject = this.gameObject.GetComponent<WaterMelon>();
                if (appleObject != null)
                {
                    Debug.Log("watermelon object is ------- " + watermelonObject);
                    tempObject = watermelonObject.getFruitObject();
                    Debug.Log("temp object is ------- " + tempObject);
                }

                else
                {
                    Debug.Log("watermelon object is ------- " + watermelonObject);
                }
                break;
            case 2:
                bananaObject = this.gameObject.GetComponent<Banana>();
                if (appleObject != null)
                {
                    Debug.Log("banbana object is ------- " + bananaObject);
                    tempObject = bananaObject.getFruitObject();
                    Debug.Log("temp object is ------- " + tempObject);
                }

                else
                {
                    Debug.Log("banana object is ------- " + bananaObject);
                }
                break;
            case 3:
                bombObject = this.gameObject.GetComponent<Bomb>();
                if (appleObject != null)
                {
                    Debug.Log("bomb object is ------- " + bombObject);
                    tempObject = bombObject.getFruitObject();
                    Debug.Log("temp object is ------- " + tempObject);
                }

                else
                {
                    Debug.Log("bomb object is ------- " + bombObject);
                }
                break;
        }
        return tempObject;
        // Instantiate(m_EnemyTypeList[a_randomInput].m_fruitObj) as GameObject;
    }
}
