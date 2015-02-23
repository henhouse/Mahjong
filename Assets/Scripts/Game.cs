using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour
{
	public GameObject clickedGameObject;

	public void Start()
	{
		clickedGameObject = null;
	}

	public void setSelected(GameObject clickedOn)
	{
		clickedGameObject = clickedOn;
	}

	public GameObject getSelected()
	{
		return clickedGameObject;
	}
}