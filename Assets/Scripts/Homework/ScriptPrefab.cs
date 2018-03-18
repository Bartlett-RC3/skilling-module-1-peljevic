using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPrefab : MonoBehaviour {
   
    public Material cubeMaterial;

	// Use this for initialization
	void Start () {
        //StartCoroutine(ChangeColor());
		
	}
	
	// Update is called once per frame
	void Update () {
       /* if (Time.time < 10)
        {

            cubeMaterial.color = Color.blue;
        }
        else if (Time.time<20){
            cubeMaterial.color = Color.magenta;
        }
        else
        {
            cubeMaterial.color = Color.green;
        }*/
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
