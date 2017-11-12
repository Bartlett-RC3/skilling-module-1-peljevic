using System.Collections;
using System.Collections.Generic;
using Application;
using UnityEngine;

/*
   Write a function that uses a condition
   Write a for loop
   Write a dog class and initialize an instance of the class
*/


public class Homework_Session02 : MonoBehaviour {

    public int positiveNumber = 2 ;
    public int a;
    public int b;

    List<Dogs> perfectPet = new List<Dogs>();

	// Use this for initialization
	void Start () {
        if (positiveNumber >0)
        {
            Debug.Log("The number " + positiveNumber + " is positive.");
        }
        else if (positiveNumber ==0)
        {
            Debug.Log("The number " + positiveNumber + " is neither positive nor negative.");
        }
        else
        {
            Debug.Log("The number " + positiveNumber + " is negative.");
        }

        //Find the sum of the numbers between a and b that are divisible by 3
        int sum = 0;
        for (int i = a; i <= b; i++)
        {
            sum = sum + i;
        }
        Debug.Log("The sum of the numbers between " + a + " and " + b + " is " + sum);

        //Create dogs
        Dogs Lana = new Dogs(5, 7, 3, true, "miniature schnauzer", "Lana");
        Dogs Pegi = new Dogs(4, 6, 3, true, "westie", "Pegi");
        Dogs Archivald = new Dogs(6, 44, 2, false, "haskey", "Archi");
        Dogs Izi = new Dogs(1, 8, 2, true, "stray", "Izi");

        perfectPet.Add(Lana);
        perfectPet.Add(Pegi);
        perfectPet.Add(Archivald);
        perfectPet.Add(Izi);

        Debug.Log("There are " + perfectPet.Count + " perfect pets");

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
