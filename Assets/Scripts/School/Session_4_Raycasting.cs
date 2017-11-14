using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Destroy(objectInFront.transform.gameObject);
//mouse raycast

public class Session_4_Raycasting : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //Store the object that is in front
        RaycastHit objectInFront;
        //ray direction
        Vector3 castedRayDirection = transform.TransformDirection(Vector3.forward);
        //Raycasting
        if (Physics.Raycast(transform.position, castedRayDirection,out objectInFront)) 
        {
            string objectInFrontName = objectInFront.transform.name;
            Debug.Log("There is an object in front of me! It's name is" + objectInFrontName);
        }
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * 0.01f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * 0.01f);
        }
	}
}
