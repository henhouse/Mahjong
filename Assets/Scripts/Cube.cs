using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour
{
	public Game game;

	void Start ()
	{
		game = GameObject.Find("Main Camera").GetComponent<Game>();
	}

	public void OnMouseDown()
	{
		renderer.materials[0].color = Color.green;
		game.DoSomethingToClicked(this.gameObject);
	}
}