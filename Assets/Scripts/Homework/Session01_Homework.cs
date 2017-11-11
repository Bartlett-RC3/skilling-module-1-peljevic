using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session01_Homework : MonoBehaviour {

    /* Session 1 homework:
    Declare a int variable and set a value
    Declare a float variable and set a value
    Declare a string variable and set a value
    Create a function that prints the declared variables
    Declare and initialize an array
    Declare and initialize a list
    Create and initialize a Dictionary */

    public int HomeworkInteger = 7;
    public float HomeworkFloat = 11.5f;

    public string HomeworkString = "Multiplication of numbers";

    public int [] homeworkIntegerArray = new int [3];
    public float[] homeworkFloatArray = { 8, 11.1f, 51.1f, 199.1f };

    public List<int> homeworkIntegerList = new List<int>();
    public List<string> FruitsOnTheImaginarySuperexpensiveMarket = new List<string>();

    Dictionary<string, float> priceOfFruit = new Dictionary<string, float>();
       
    float HomeworkFunction(float firstVariable, float secondVariable)
    {
        float Multiplication = firstVariable * secondVariable;
        return Multiplication;
    }    


    // Use this for initialization
    void Start () {
       
        Debug.Log( HomeworkString + HomeworkInteger + " and " + HomeworkFloat + " is " + HomeworkFunction(HomeworkInteger, HomeworkFloat));
       
        homeworkFloatArray[2] = 13.3f;
        homeworkIntegerArray[1] = homeworkIntegerArray[0]+1;
        homeworkIntegerArray[2] = homeworkIntegerArray[1] * 3;
        homeworkIntegerList.Add(2);
        homeworkIntegerList.Add(55);

        FruitsOnTheImaginarySuperexpensiveMarket.Add("apple");
        FruitsOnTheImaginarySuperexpensiveMarket.Add("banana");
        FruitsOnTheImaginarySuperexpensiveMarket.Add("pineapple");
       

        priceOfFruit.Add ( FruitsOnTheImaginarySuperexpensiveMarket [0], HomeworkInteger );
        priceOfFruit.Add ( "mango", homeworkFloatArray[1] );
        priceOfFruit.Add ( FruitsOnTheImaginarySuperexpensiveMarket [2], HomeworkFloat );

        Debug.Log("Price of " + FruitsOnTheImaginarySuperexpensiveMarket[2] + " is " + priceOfFruit[FruitsOnTheImaginarySuperexpensiveMarket[2]]);
        Debug.Log("In the store " + priceOfFruit.Count + " fruts are too expensive.");
	}
	
	// Update is called once per frame
	void Update () {
        homeworkIntegerList.Remove(2);
		
	}

}
