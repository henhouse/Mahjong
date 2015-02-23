using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour
{
	public Game game;
	
	void Start()
	{
		game = GameObject.Find("Main Camera").GetComponent<Game>();
	}

	public void OnMouseDown()
	{
		// No currently selected cube
		if (game.clickedGameObject == null)
		{
			game.setSelected(this.gameObject);
			toggleHighlight(renderer.material.color);
		}
		else
		{
			print ("poop.");
			// Second clicked cube is the already selected cube
			if (this.gameObject == game.clickedGameObject)
			{
				game.setSelected(null);
				toggleHighlight(renderer.material.color, false);
			}
			// Second clicked cube is not the same pattern
			else if (game.clickedGameObject.tag != this.tag)
			{
				toggleHighlight(this.renderer.material.color, false);
				toggleHighlight(game.clickedGameObject.renderer.material.color, false);
				game.setSelected(null);
			}
			// Second clicked cube is different tag, destroy both
			else
			{
				Destroy(this.gameObject);
				Destroy(game.clickedGameObject);
				game.setSelected(null);
			}
		}
	}

	public void toggleHighlight(Color c)
	{
		toggleHighlight(c, true);
	}
	
	private void toggleHighlight(Color c, bool off)
	{
		if (off)
			c.a = 0.7f; // opacity to 70%
		else if (!off)
			c.a = 1.0f;
		
		renderer.material.color = c;
	}
}