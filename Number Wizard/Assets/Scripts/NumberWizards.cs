using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {
	
	int guess = 1000/2;
	int min = 1;
	int max = 1000;
	bool found = false;
	// Use this for initialization
	void Start () {
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me.");
		
		print ("The Highest number you can pick is " + max + ".");
		print ("The lowest number you can pick is " + min + ".");
		
		print ("Is the number higher or lower than " + guess + "?");
		
		print ("Press UP arrow for higher, DOWN arrow for lower, and RETURN for equals.");
		
	}
	
	// Update is called once per frame
	void Update () {
		if(!found){
			if(Input.GetKeyDown(KeyCode.Return)) {
				print ("RETURN");
				print ("I won!!! Your number is " + guess);
				found = true;
			} else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow)) {
				
				if(Input.GetKeyDown(KeyCode.UpArrow)) {
					print ("HIGHER");
					min = guess;
					
				} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
					print ("LOWER");
					max = guess;				
				}	
				guess = (max - min)/2 + min;
				print ("Is the number higher or lower than or equal to " + (guess));
				
			}
		} else {
			min = 1;
			max = 1000;
			guess = 1000/2;
			found = false;
			print ("Pick a number in your head, but don't tell me.");
			print ("The Highest number you can pick is " + max + ".");
			print ("The lowest number you can pick is " + min + ".");
			
			print ("Is the number higher or lower than " + guess + "?");
			
			print ("Press UP arrow for higher, DOWN arrow for lower, and RETURN for equals.");
		}

	}
	
}
