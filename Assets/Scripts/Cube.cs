using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour
{
	public Game game;

	void Start() {
		game = GameObject.Find("Main Camera").GetComponent<Game>();
	}

	public void OnMouseDown()
	{
		Cube selected = game.getSelected ();

		// No currently selected cube
		if (selected == null) {
			game.setSelected(this);
			toggleHighlight(true);
		}
		else {
			// Second clicked cube is the already selected cube
			if (this == game.getSelected()) {
				game.setSelected(null);
				toggleHighlight(false);
				print("Same cube");
			}
			// Second clicked cube is not the same pattern
			else if (!(selected.tag.Equals(this.tag))) {
				toggleHighlight(false);
				selected.toggleHighlight(false);
				game.setSelected(null);
				print ("different tag");
				print ("this.tag: " + this.tag + "\nselected.tag: " + selected.tag);
			}
			// Second clicked cube is different tag, destroy both
			else {
				// cast 4 rays in all directions. If there is >1 collision, do nothing.
				if (this.twoSidesOpen() && selected.twoSidesOpen()) {
					print ("Two sides open, should destroy both.");
					Destroy(this.gameObject);
					Destroy(selected.gameObject);
					Util.matches--;
				} else {
					game.setSelected(null);
					selected.toggleHighlight(false);
					print ("Two sides not open.");
				}
			}
		}
	}

	public bool twoSidesOpen() {
		int numCollided = 0;
		float rayDistance = 1f;

		Vector3 left = transform.TransformDirection (Vector3.left);
		Vector3 right = transform.TransformDirection (Vector3.right);

		bool leftCollided = Physics.Raycast (transform.position, left, rayDistance);
		bool rightCollided = Physics.Raycast (transform.position, right, rayDistance);

		if (leftCollided) numCollided++;
		if (rightCollided) numCollided++;

		if (numCollided > 1) return false;
		else return true;
	}

	private void toggleHighlight(bool toggleOn) {
		Color c = renderer.material.color;
		if (toggleOn) c.a = 0.7f; // opacity to 70%
		else c.a = 1.0f;
		renderer.material.color = c;
	}
}