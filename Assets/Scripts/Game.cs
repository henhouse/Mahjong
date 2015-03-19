using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour
{

	void Update() {
		if (GameObject.Find("Cube") == null) {
			//Instantiate(
		}
	}

	public Cube clickedCube;

	public void setSelected(Cube clickedOn)
	{
		clickedCube = clickedOn;
	}

	public Cube getSelected()
	{
		return clickedCube;
	}
}