using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 Create a cube and move it across the screen
 Create a cube and change its colour when key is pressed or mouse is pressed
 Add a script to a game object
*/

public class Session03_Homework : MonoBehaviour
{

    int counter = 0;
    public GameObject cubeHomework;
    bool moveLeft = true;
    bool moveRight = false;
    bool moveUp = true;
    bool moveDown = false;
    int counterX = 0;
    public Color cubeColor;
    public Material cubeMateriak;
   

    // Use this for initialization
    void Start()
    {
        cubeMateriak.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {

        // Move the cube up and down
        if (moveUp == true)
        {
            if (counter <= 12)
            {

                gameObject.transform.Translate(Vector3.up);
                counter++;
            }
            else
            {
                moveUp = false;
                moveDown = true;
                counter = 0;
            }
        }
        if (moveDown == true)
        {
            if (counter <= 12)
            {
                gameObject.transform.Translate(Vector3.down);
                counter++;
            }


            else
            {
                moveDown = false;
                moveUp = true;
                counter = 0;
            }
        }

        // Move the cube left and right
        if (moveLeft == true)
        {
            if (counterX<= 12)
            {
                gameObject.transform.Translate(Vector3.left);
                counterX +=3;
            }

            else
            {
                moveLeft = false;
                moveRight = true;
                counterX = 0;
            }
        }
        else if (moveRight == true)
        {
            if (counterX <= 12)
            {
                gameObject.transform.Translate(Vector3.right);
                counterX+=3;
            }
            else
            {
                moveRight = false;
                moveLeft = true;
                counterX = 0;
            }

        }

        if (Input.GetKey(KeyCode.C) || Input.GetMouseButton(0))
        {
            //gameObject.renderer.material.color = new Color(R, G, B, A);

            if(cubeMateriak.color == Color.white)
            {
                cubeMateriak.color = Color.blue;
            }
            else
            {
                cubeMateriak.color = Color.white;
            }
        }
        if (Input.GetKey(KeyCode.Space) || Input.GetMouseButton(1))
        {
           
            if (cubeMateriak.color != Color.magenta)
            {
                cubeMateriak.color = Color.magenta;
            }
            else
            {
                cubeMateriak.color = Color.white;
            }

        }

    
    }

}