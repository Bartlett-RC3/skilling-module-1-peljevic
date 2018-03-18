using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 Create a cube prefab that has a script attached to it
 Write a change colour coroutine
 Create a cube array and change destroy them in play mode using ray casting
 Destroy(objectInFront.transform.gameObject);
 mouse raycast
*/



public class Session04_Homework : MonoBehaviour 
{



    // Update is called once per frame
    void Update()
    {
        RaycastHit objectInFront;

       
        //public MouseUtils.Button respondToMouseButton = MouseUtils.Button.Left;

        Vector3 castedRayDirection = transform.TransformDirection(Vector3.forward);
        //Raycasting
        if (Physics.Raycast(transform.position, castedRayDirection, out objectInFront))
        {
            string objectInFrontName = objectInFront.transform.name;
            Debug.Log("There is an object in front of me! It's name is" + objectInFrontName);

            Destroy(objectInFront.transform.gameObject);

        }

    }
    public void OnMouseEnter()
    {
        Destroy(this.transform.gameObject);
    }

        public void OnMouseOver()
        {
            //if (Input.GetMouseButtonDown((int)respondToMouseButton))
            //  Destroy(this.gameObject);
        }

}
