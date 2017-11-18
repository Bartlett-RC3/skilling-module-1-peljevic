using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Create a cube prefab that has a script attached to it
Write a change colour coroutine
Create a cube array and change destroy them in play mode using ray casting
*/

public class Session04_Homework : MonoBehaviour
{

    public GameObject CubeRaincast;
    public Color cubeColor;
    public Material cubeMaterial;
    IEnumerator ColorCoroutine;



    // Use this for initialization
    void Start()
    {

        ColorCoroutine = ChangeColor();
        cubeMaterial.color = Color.green;
        /* if(Time.time>10)
         {
             StopCoroutine(ColorCoroutine);
             StopAllCoroutines();
         } */


    }

    // Update is called once per frame
    void Update()
    {

        StartCoroutine(ColorCoroutine);


        Debug.Log(Time.time);
    }
    IEnumerator ChangeColor()
    {
        /*{  if (cubeMaterial.color == Color.white)
            {
                cubeMaterial.color = Color.blue;
            }
            else
            {
            cubeMaterial.color = Color.white;
            }
        }*/

        for (float f = 1f; f >= 0; f -= 0.1f)
        {
            Color c = cubeMaterial.color;
            c.a = f;
            cubeMaterial.color = c;
            yield return new WaitForSeconds(.1f);

        }
    }

        Vector3 mouseScreenPosition = Input.mousePosition;
        RaycastHit objectInFront;
        Destroy(objectInFront.transform.gameObject);
   


}

   