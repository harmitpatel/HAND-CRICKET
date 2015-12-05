using UnityEngine;
using System.Collections;
using Leap;

public class HandDetector : MonoBehaviour 
{

  public HandController leap_controller_;

  [SerializeField]
  private ScoreUpdater m_scoreUpdaterObj;
  [SerializeField]
  private FruitFactory m_fruitPositionerObj;
  [SerializeField]
  private DynamiteAdapter m_dynamiteAdapterObj;
  [SerializeField]
  private Kiwi m_kiwiObj;
  [SerializeField]
  private Banana m_banaobj;
  [SerializeField]
  private Pumpkin m_pumpkin;
  


  void Start()
  {

     m_dynamiteAdapterObj = m_dynamiteAdapterObj.GetComponent<DynamiteAdapter>();
     m_kiwiObj = m_kiwiObj.GetComponent<Kiwi>();
     m_banaobj = m_kiwiObj.GetComponent<Banana>();
     m_pumpkin = m_kiwiObj.GetComponent<Pumpkin>();

 
  }

  HandModel GetHand(Collider other)
  {
    HandModel hand_model = null;
    // Navigate a maximum of 3 levels to find the HandModel component.
    int level = 1;
    Transform parent = other.transform.parent;
    while (parent != null && level < 3) {
      hand_model = parent.GetComponent<HandModel>();
      if (hand_model != null) {
        break;
      }
      parent = parent.parent;
    }

    return hand_model;
  }

  // Finds the first instance (by depth-firstrecursion)
  // of a child with the specified name
  Transform FindPart(Transform parent, string name) {
    if (parent == null) {
      return parent;
    }
    if (parent.name == name) {
      return parent;
    }
    for (int c = 0; c < parent.childCount; c++) {
      Transform part = FindPart(parent.GetChild(c), name);
      if (part != null) {
        return part;
      }
    }
    return null;
  }

    
  void OnTriggerEnter(Collider other)
  {
    HandModel hand_model = GetHand(other);
    if (hand_model != null)
    {
      int handID = hand_model.GetLeapHand().Id;
      HandModel[] hand_models = leap_controller_.GetAllGraphicsHands();
      for (int i = 0; i < hand_models.Length; ++i)
      {
        if (hand_models[i].GetLeapHand().Id == handID)
        {
          Transform part = null;
          if (other.transform.parent.GetComponent<HandModel>() != null) {
            // Palm or Forearm components
            part = FindPart(hand_models[i].transform, other.name);
          } else if (other.transform.parent.GetComponent<FingerModel>() != null) {
            // Bone in a finger
            part = FindPart(FindPart(hand_models[i].transform, other.transform.parent.name), other.name);
          }
          //Debug.Log ("Detected: " + other.transform.parent.name + "/" + other.gameObject.name);
          //if (part != null) 
         // {


              //m_scoreUpdaterObj.m_score += 5;
            //Renderer[] renderers = part.GetComponentsInChildren<Renderer>();
            //foreach(Renderer renderer in renderers) {
              //Debug.Log ("qwertyuiop[");
            //renderer.material.color = Color.red;

              if (this.gameObject.tag == "dynamite")
              {
                  m_dynamiteAdapterObj.DeactivatedFruit();
              }

              else if (this.gameObject.tag  == "kiwi")
              {
                  m_kiwiObj.UpdateScore(m_scoreUpdaterObj);
              }

              else if (this.gameObject.tag == "banana")
              {
                  m_kiwiObj.UpdateScore(m_scoreUpdaterObj);
              }

              else if (this.gameObject.tag == "pumpkin")
              {
                  m_kiwiObj.UpdateScore(m_scoreUpdaterObj);
              }
              


            // }
         // }
        }
      }
    }
  }
}
