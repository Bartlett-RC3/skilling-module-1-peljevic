// Refrences
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Where code lives
// Extends (:) UnityLanguage = MonoBehavior
public class Session_1 : MonoBehaviour {

    // 1.Variables
    // Type - - Name - - Value
    // Scope - - Type - - Name - - Value

    // Numbers

    public int myFirstIntegerNumber = 97;
    float myFirstFloatNumber = 1.71f;

    // Text
    public string myFirstString = "My text is somewhere";

    // Logical variable
    bool myFirstBoolean = true;

    // Data structures
    // Scope - - Type - - Values

    //3.a.Arrays
    public int[] myIntegerArray = { 1, 2, 3, 4, 5 };
    public float[] myFloatArray = new float[5];

    //3.b.Lists
    //new things always added at the end
    public List<int> myIntegerList = new List<int>();


    //2.Functions
    //Scope - - Type - - Variables - - Body (Instructions)

	// Use this for initialization
	//Start runs only once - sometimes called Setup 
    void Start () {
        Debug.Log("Addition of 5 and 3 is: " + AdditionofNumbers(5, 3));
        //You can only add value in the function therefore
        myFloatArray[2] = 3.2f;
        myFloatArray[3] = 4.3f;
        myFloatArray[4] = 9.2f;

        myIntegerList.Add(1);
        myIntegerList.Add(2);
        myIntegerList.Add(3);

        //myIntegerList.Remove(0);
	}
	
	// Update is called once per frame
	// Runs one time per frame
    void Update () {
        Debug.Log("Hello world!");
    }
    int AdditionofNumbers(int number1, int number2)
    {
        int additionResult = number1 + number2;
        return additionResult;
    }

}

   