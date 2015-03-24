using UnityEngine;
using System.Collections;

public class Util : MonoBehaviour {

	public GUIText timeScore;
	public GUIText matchesLeft;
	public GUIText youWin;
	public static int matches = 18;
	public static float time = 0;
	bool won = false;

	void Start()
	{
		youWin.enabled = false;
	}

	// Update is called once per frame
	void Update()
	{
		if (!won) {
			time += Time.deltaTime;
			timeScore.text = "Time: " + time;
			//Application.LoadLevel (0);
		}

		matchesLeft.text = "Matches Left: " + matches;
		if (matches == 0) {
			won = true;
			youWin.enabled = true;
		}
	}
}
