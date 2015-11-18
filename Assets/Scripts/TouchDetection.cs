using UnityEngine;
using System.Collections;
using Leap;

public class TouchDetection : MonoBehaviour 
{

	// Use this for initialization
	void Start ()
    {
        Debug.Log("wertyhjkl");
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}


    //bool isHandTrackingEnabled = controller.Config.GetBool("tracking_hand_enabled");


    private bool IsHand(Collider other)
    {
        if (other.transform.parent && other.transform.parent.parent && other.transform.parent.parent.GetComponent<HandModel>())
        {
            Debug.Log("in the collision snippet");
            return true;
        }

        else
        {
            Debug.Log("cannot detect baby");
        }
            return false;
    }

    private HandModel GetHand(Collider other)
    {
        if (other.transform.parent && other.transform.parent.parent.parent &&
            other.transform.parent.parent.GetComponent<HandModel>())
            return other.transform.parent.parent.GetComponent<HandModel>();
        else
            return null;
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "fruit")
        {
            if (IsHand(other))
            {
                Debug.Log("Yay! A hand collided!");
            }

            HandModel handModel = GetHand(other);
            if (handModel != null)
            {
                Debug.Log("Yay! A hand collided!");
            }
        }
       
    }
}
