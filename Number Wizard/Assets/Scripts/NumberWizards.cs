using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {
	
	int guess;
	int min;
	int max;

	// Use this for initialization
	void Start () {
		DisplayNewGame();
	}
	
	void DisplayInstructions() {
		print ("Press UP arrow for higher, DOWN arrow for lower, and RETURN for equals.");
	}
	
	void DisplayNewGame () {
		min = 1;
		max = 1000;
		print ("==============================================");
		print ("Pick a number in your head, but don't tell me.");
		print ("The Highest number you can pick is " + max + ".");
		print ("The lowest number you can pick is " + min + ".");
		max = max + 1;
		guess = max/2;
		print ("Is the number higher or lower than or equal to " + guess + "?");
		DisplayInstructions();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Return)) {
			print ("RETURN");
			print ("I won!!! Your number is " + guess);
			DisplayNewGame();
		} else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow)) {
			if(Input.GetKeyDown(KeyCode.UpArrow)) {
				print ("HIGHER");
				min = guess;
				
			} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
				print ("LOWER");
				max = guess;				
			}	
			guess = (max + min)/2;
			print ("Is the number higher or lower than or equal to " + guess);
			DisplayInstructions();
		}
	}
}
