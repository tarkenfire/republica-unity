using UnityEngine;
using System.Collections;

public class GameOverPage : OGPage
{
	private OGLabel aftermath;

	public override void StartPage()
	{
		//set text to reflect score
		GameObject refObject;
		
		refObject = GameObject.Find("aftermathText");
		aftermath = (OGLabel)refObject.GetComponent<OGLabel>();
		aftermath.text = "Game is over, final score is: " + MainPage.score;
		
	}
	
	public void onMenuClick()
	{
		Application.LoadLevel("MainMenuScene");
	}

	public void onLeaderboardClick()
	{
		Application.LoadLevel("Leaderboard");
	}
	
}
