using UnityEngine;
using System.Collections;

public class MenuPage : OGPage
{
	public override void StartPage()
	{
	}

	public void onAchvClick()
	{
		Application.LoadLevel("AchScene");
	}

	public void onPlayPressed()
	{
		Application.LoadLevel("MainSceen");
	}

}
