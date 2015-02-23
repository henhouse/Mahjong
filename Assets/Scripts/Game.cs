using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour
{
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