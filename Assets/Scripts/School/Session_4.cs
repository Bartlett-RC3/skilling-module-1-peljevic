using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Null - pointing something that doesn't exist
//Coroutine - - continuos routines - - starting something , waiting something else to happen, than continue - -  conditional f-on - yield - - IEnumerator
// Kvaternion - ojlerovi uglovi, cetvrta dimenzija smer iliti blend na primer dve rotiras za prav ugao stvaras blend i dobijas cetrspet

public class Session_4 : MonoBehaviour {
  
    //Variables

    public GameObject columnPrefab;
    IEnumerator CreateColumnCoroutine;


    // Use this for initialization
	void Start () {

        CreateColumnCoroutine = DropColumns();
           
        //float x = Random.Range(0, 100);
        //float x = UnityEngine.Random.Range(1, 10); 
	}
	
	// Update is called once per frame
	void Update () {
		
        StartCoroutine(CreateColumnCoroutine);
        Debug.Log(Time.time);

        if(Time.time>5)
        {
            StopCoroutine(CreateColumnCoroutine);
            StopAllCoroutines();
        }	
    }

    //Corountnes

    IEnumerator DropColumns()
    {
        while (true)
        {
            Vector3 columnPosition = new Vector3(Random.Range(-5f, 2.5f), Random.Range(8f, 15f), Random.Range(-7f, 4f));
            float x = Random.Range(0, 90);
            float y = Random.Range(0, 90);
            float z = Random.Range(0, 90);
            Quaternion columnRotation = new Quaternion(x,y,z,1);
            GameObject newColumn = Instantiate(columnPrefab, columnPosition, columnRotation);
            yield return new WaitForSeconds(5);
        }
       
    } 
}
