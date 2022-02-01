using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenceScript : MonoBehaviour
{
    //This is an example of a comment

    //Function example
    void Start()
    //Function Being Defined
    {
        Debug.Log("This is a statement within a function");
        //Statement within a function
    }

    //function is called after the start function
    void LateStart()
    {   //Variable being defined
        string Variable1 = "This is an example of a variable being defined";
        //statement printing the variable
        Debug.Log(Variable1);



    }
    //function that is being called once per update
    void Update()
    {
        for (int u = 0; u < 5; u++)
        {
            //For loop repeating the process of adding one to variable u


        }
    }






}
