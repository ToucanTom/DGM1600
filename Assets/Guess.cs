using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guess : MonoBehaviour {
   private int max = 100;
   private int min = 1;
   private int guess;
   public int counter = 5;
    // Use this for initialization
    void Start () {
       guess = Random.Range(min, max);
        print("Welcome to Number Guesser");
        print("Pick a number in your head");

        print("The highest number you can pick is "+ max);
        print("The lowest number you can pick is " + min);

        print("Is the number higher or lower than "+guess +"?");
        print("Up arrow for higher, Down for lower, Enter for equal");
    }
	
	// Update is called once per frame
	void Update () {
        if (counter == -1)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                print("player wins!");
            }
        }
else
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) && counter > 0)
            {
                min = guess + 1;
                guess = (max + min) / 2;
                print("Is the number higher or lower than " + guess + "?");
                counter--;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) && counter > 0)
            {
                max = guess - 1;
                guess = (max + min) / 2;
                print("Is the number higher or lower than " + guess + "?");
                counter--;
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                print("The number is " + guess + "! the computer won in " + (5 - counter) + "guesses");
            }
            if (counter == 0)
            {
                counter--;
                print("This is my last guess! press return if I am right, up or down if I am wrong");


            }
        }
       
     
    }
}
