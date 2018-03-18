using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptForThePrefab : MonoBehaviour
{

    GameObject[] CubeArray;

    //public GameObject Cube_AttachedScript;
    IEnumerator CreateArray;
    //float counter;
    public Material cubeMaterial;
    public Camera camera;

    void Start()
    {
        StartCoroutine(ChangeColor());
    }
    void Update()
    {

        //public MouseUtils.Button respondToMouseButton = MouseUtils.Button.Left;

        Vector3 castedRayDirection = transform.TransformDirection(Vector3.forward);
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 10000))
        //Raycasting
        //  if (Physics.Raycast(transform.position, castedRayDirection, out objectInFront))
        {
            string objectInFrontName = hit.transform.name;
            Debug.Log("There is an object in front of me! It's name is" + objectInFrontName);

            Destroy(hit.transform.gameObject);

        }


    }

    IEnumerator ChangeColor()
    {
        if (cubeMaterial.color != Color.magenta)
        {
            cubeMaterial.color = Color.magenta;
        }
        else
        {
            cubeMaterial.color = Color.blue;
        }
        yield return new WaitForSeconds(0.5f);
    }

}
