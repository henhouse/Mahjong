using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour
{
	public Game game;
	public bool highlighted;
	
	void Start ()
	{
		game = GameObject.Find("Main Camera").GetComponent<Game>();
	}
	
	public void OnMouseDown()
	{
		// No currently selected cube
		if (game.selected == null) {
			game.selected = this.gameObject;
			toggleHighlight ();
		}
		else {
			// Second clicked cube is the already selected cube
			if (this.gameObject == game.selected || game.selected.gameObject.tag != this.gameObject.tag)
				toggleHighlight ();
			// Second clicked cube is different tag, destroy both
			else {
				Destroy(this);
				Destroy (game.selected);
				game.selected = null;
			}
		}
		
	}
}