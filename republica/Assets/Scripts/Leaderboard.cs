using UnityEngine;
using System.Collections;

public class GameOverPage : OGPage
{
	public override void StartPage()
	{}
	
	public void onMenuClick()
	{
		Application.LoadLevel("MainMenuScene");
	}
}
