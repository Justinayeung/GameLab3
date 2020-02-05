using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayCode : MonoBehaviour
{
    //Use an array when you know your data or amount beforehand
    string[] myArray;

    string[] myFirstArray = { "One", "Two", "Three" };
    string[] mySecondArray;

    //Unlike an array (length) a list is where the number of elemennts (count) can change dynamically
    //When you call new = you are also clearing what was in the list before
    List<GameObject> myList = new List<GameObject>();

    List<string> myGreetings = new List<string>();

    //Functions like a list BUT
    Queue<int> myQ = new Queue<int>();

    void Start() {

        //Like a line, when you add(enqueue) that first object will be the first to be removed(dequeue)
        //myQ.Enqueue(1);
        //myQ.Dequeue();

        //---------------------------------------
        //IntArray = new int[10];
        //If you initialize a public array in Start()
        //Anything you enter in the inspector will be overwritten when you run the scene

        mySecondArray = myFirstArray;
        myFirstArray[0] = "A different string";
        Debug.Log(mySecondArray[0]); //The debug will read "A different string" = it does this because it passes it by reference not by value (by ref, by val)

        //A for loop can do everything a foreach loop can do, but a foreach loop can't do everything a for loop does
        //If you go through a foreach, you can't debug what number you are on (i in a for loop)
        //Use foreach for collision data or if you want to delete everything
        //Foreach should be used when you want to just loop through everything

        //Pring all values to the console
        for (int i = 0; i < myFirstArray.Length; i++) {
            print(myFirstArray[i]);
        }

        //----------------------------------------
        //Adding to lists
        myGreetings.Add("Hello");
        myGreetings.Add("Greetings");
        myGreetings.Add("What's up");
        myGreetings.Add("Salutations");
        //Debug.Log(myGreetings[0]);
        Debug.Log(myGreetings[Random.Range(0, myGreetings.Count)]);


        //myList.Add(gameObject);
        //foreach (var obj in myList) {
        //    Debug.LogFormat("Object name in {0}", obj.name);
        //}
        //myList.Remove(gameObject);

        Debug.Log(HelloListMaker(5)[2]);

        List<string> newList = HelloListMaker(10);
        for (int i = 0; i < newList.Count; i++) {
            Debug.Log(newList[i]);
        }

        int[] newArray = new int[] { 0, 1, 2, 3, 4, 5, 6 };
        Debug.Log(LastItemDoubler(newArray));
    }

    void Update() {
        //Local Arrays
        //Explicitly declared
        myArray = new string[] { "my", "code", "names" };
        //Debug.Log(myArray[1]);

        //Implicitly declared
        var myArray2 = new[] { "my", "code", "names" };

        //USUALLY you will not be pre-populating the arrays  
        
        //Instantiating and Destroying are expensive, if you have a lot of things you want to instantiate
        //It is more efficient to instantiate them all and move them 
    }

    //TODO: new function, you pass an integar, returns a string list containing "HELLO" that many times
    //eg: I call this with 5, I get back a list that is length 5, containing "HELLO" 5 times

    List<string> HelloListMaker(int quantity) {
        List<string> toReturn = new List<string>();
        for (int i = 0; i < quantity; i++) {
            toReturn.Add("HELLO");
        }
        return toReturn;
    }

    //TODO: new function, you pass it an array of integers, and it returns the last item * 2

    int LastItemDoubler(int[] intArray) {
        return intArray[intArray.Length - 1] * 2;
    }
}
