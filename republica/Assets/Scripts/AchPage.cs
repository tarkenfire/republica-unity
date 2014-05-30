using UnityEngine;

public class AchPage: OGPage
{
	private OGTickBox compAch, mesAch, negAch, t1Ach, t2Ach, t3Ach;

	public override void StartPage()
	{
		//get UI handles
		GameObject refObject;
		
		refObject = GameObject.Find("compAch");
		compAch = (OGTickBox)refObject.GetComponent<OGTickBox>();

		refObject = GameObject.Find("mesAch");
		mesAch = (OGTickBox)refObject.GetComponent<OGTickBox>();

		refObject = GameObject.Find("negAch");
		negAch = (OGTickBox)refObject.GetComponent<OGTickBox>();

		refObject = GameObject.Find("tier1Ach");
		t1Ach = (OGTickBox)refObject.GetComponent<OGTickBox>();

		refObject = GameObject.Find("tier2Ach");
		t2Ach = (OGTickBox)refObject.GetComponent<OGTickBox>();

		refObject = GameObject.Find("tier3Ach");
		t3Ach = (OGTickBox)refObject.GetComponent<OGTickBox>();

		//set relevent achvs
		if (MainPage.lameDuck) 
		{
			negAch.isTicked = true;
		}

		if (MainPage.pass10) 
		{
			t1Ach.isTicked = true;
		}

		if (MainPage.pass20) 
		{
			t2Ach.isTicked = true;
		}

		if (MainPage.pass30) 
		{
			t3Ach.isTicked = true;
		}

		if (MainPage.office40) 
		{
			mesAch.isTicked = true;
		}

		if (MainPage.pass10 && MainPage.pass20 && MainPage.pass30) 
		{
			compAch.isTicked = true;
		}

	}

	public void onMenuClick()
	{
		Application.LoadLevel("MainMenuScene");
	}
}