using UnityEngine;
using System.Collections;

public class LeaderboardScene: OGPage
{
	public override void StartPage()
	{}
	
	public void onMenuClick()
	{
		Application.LoadLevel("MainMenuScene");
	}
}
