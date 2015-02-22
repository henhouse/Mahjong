using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

	public GameObject clickedGameObject;
	
	public void DoSomethingToClicked(GameObject clickedOn)
	{
		clickedGameObject = clickedOn;
		print ("hi i ran.");
	}
}