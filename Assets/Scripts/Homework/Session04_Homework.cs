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
    public GameObject CubePrefab;
    IEnumerator CreateArray;

    void Start()
    {
        CreateArray = MakeArrayOfCubes();
        StartCoroutine(CreateArray);
    }



    IEnumerator MakeArrayOfCubes()
    {
        while (Time.time < 30)
        {
            Vector3 position = new Vector3(1.5f * Time.time, 2f * Time.time, 1.75f * Time.time);
            //float x = Random.Range(0, 90);
            //float y = Random.Range(0, 90);
            //float z = Random.Range(0, 90);
            Quaternion rotation = new Quaternion(0, 0, 0, 1);
            GameObject newCubeArray = Instantiate(CubePrefab, position, rotation);
            yield return new WaitForSeconds(1);
        }
    }
}
