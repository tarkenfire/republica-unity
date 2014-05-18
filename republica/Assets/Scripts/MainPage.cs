using UnityEngine;

public class MainPage : OGPage
{
	int turnNumber = 1;
	private int pcPoints = 1000, cfPoints = 0, plPoints = 0;

	//ui refs
	private OGTextField pcLabel, cfLabel, plLabel;
	private OGButton addPLButton, addCFButton, nextTurnButton;
	private OGProgressBar supportMeter;

	//button handlers
	public void onNextTurn()
	{
		pcPoints += 500;
		setPointTotals();
	}

	public void addCFPoints()
	{
		if (pcPoints - 500 >= 0) 
		{
			++cfPoints;
			pcPoints -= 500;
		}
	
		//TODO: Add user feedback.
		setPointTotals();
	}

	public void addPLPoints()
	{
		if (pcPoints - 500 >= 0) 
		{
			++plPoints;
			pcPoints -= 500;
		}

		setPointTotals();
	}


	public override void StartPage()
	{
		setUIHandles();
		setPointTotals();
	}

	//support functions
	private void setUIHandles()
	{
		GameObject refObject;

		refObject = GameObject.Find("PCLabel");
		pcLabel = (OGTextField)refObject.GetComponent<OGTextField>();

		refObject = GameObject.Find("CFLabel");
		cfLabel = (OGTextField)refObject.GetComponent<OGTextField>();

		refObject = GameObject.Find("PLLabel");
		plLabel = (OGTextField)refObject.GetComponent<OGTextField>();

		refObject = GameObject.Find("AddPLButton");
		addPLButton = (OGButton)refObject.GetComponent<OGButton>();

		refObject = GameObject.Find("AddCFButton");
		addCFButton = (OGButton)refObject.GetComponent<OGButton>();

		refObject = GameObject.Find("NextTurnButton");
		nextTurnButton = (OGButton)refObject.GetComponent<OGButton>();

		refObject = GameObject.Find("SupportMeter");
		supportMeter = (OGProgressBar)refObject.GetComponent<OGProgressBar>();
	}

	private void setPointTotals()
	{
		pcLabel.text = "Political Capital: " + pcPoints;
		cfLabel.text = "Camp. Funds: " + cfPoints;
		plLabel.text = "Leverage: " + plPoints;
	}

}
