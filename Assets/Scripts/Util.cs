using UnityEngine;
using System.Collections;

public class Util : MonoBehaviour {

	public GUIText timeLeft;
	public GUIText matchesLeft;
	public GUIText youWin;
	public static int matches = 18;
	public static float time = 45;
	bool won = false;

	void Start()
	{
		youWin.enabled = false;
	}
	
	// Update is called once per frame
	void Update()
	{
		if (!won) {
			time -= Time.deltaTime;
			timeLeft.text = "Time Left: " + time;
			if (time < 0)
			{
				Application.LoadLevel (0);
				time = 30;
				matches = 18;
			}
		}

		matchesLeft.text = "Matches Left: " + matches;
		if (matches == 0) {
			won = true;
			youWin.enabled = true;
		}
	}
}
