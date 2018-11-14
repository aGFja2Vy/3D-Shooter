/* Payton erickson
2017 Dec 15
GAM50
Vista Murrieta High School- Ms.McLeod
24 Hour book code finish line */

using UnityEngine;
using System.Collections;

public class FinishScript : MonoBehaviour {

	public GameControlScript gameControlScript;
	
	// When an object enters the finish zone, let the
	// game control know that the current game has ended
	void OnTriggerEnter(Collider other)
	{
		gameControlScript.FinishedGame();
	}
}
