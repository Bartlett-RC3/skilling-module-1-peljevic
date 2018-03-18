using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptForThePrefab : MonoBehaviour {

    GameObject[] CubeArray;
    public GameObject Cube_AttachedScript;
    IEnumerator CreateArray;
    //float counter;
    public Material cubeMaterial;


	void Start () 
    {
        CreateArray = MakeArrayOfCubes();
        StartCoroutine(CreateArray);
        StartCoroutine(ChangeColor());
	}
	
	
	void Update ()
    {
        
	}

    IEnumerator MakeArrayOfCubes() 
    {
        while (Time.time<30)
        {
            Vector3 position = new Vector3(1.5f * Time.time, 2f * Time.time, 1.75f * Time.time);
            //float x = Random.Range(0, 90);
            //float y = Random.Range(0, 90);
            //float z = Random.Range(0, 90);
            Quaternion rotation = new Quaternion(0, 0, 0, 1);
            GameObject newCubeArray = Instantiate(Cube_AttachedScript, position, rotation);
            yield return new WaitForSeconds(1);
        }
    }

    IEnumerator ChangeColor()
    {
        if (cubeMaterial.color != Color.magenta){
            cubeMaterial.color = Color.magenta;
        }
        else {
                cubeMaterial.color = Color.blue;
        }
        yield return new WaitForSeconds(0.5f);
    }

}
