using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour
{
	public Game game;

	void Start ()
	{
		// select main "Game" script and assign
		game = GameObject.Find("Main Camera").GetComponent<Game>();
	}

	public void OnMouseDown()
	{
		Color c = renderer.materials [0].color;
		//c = Color.yellow;
		c.a = 0.7f; // opacity to 70%
		renderer.material.color = c;
		game.DoSomethingToClicked(this.gameObject);
	}
}