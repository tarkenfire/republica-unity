using UnityEngine;

public class MainPage : OGPage
{
	int turnNumber = 1;
	public static int score = 0;
	private int pcPoints = 1000, cfPoints = 0, plPoints = 0;

	public static bool pass10 = false, pass20 = false, pass30 = false;
	public static bool office40 = false;
	public static bool lameDuck = false;

	private float partySupport = .5f;

	//ui refs
	private OGTextField pcLabel, cfLabel, plLabel;
	private OGButton addPLButton, addCFButton, nextTurnButton;
	private OGProgressBar supportMeter;
	private OGTickBox camTick1, legTick1;

	//button handlers
	public void onNextTurn()
	{
		if (partySupport <= 0 || turnNumber >= 100) 
		{

			if (score == 0)
			{
				MainPage.lameDuck = true;
			}

			endGame();
		}


		pcPoints += 500;
		
		if (camTick1.isTicked && cfPoints - 1 >= 0) {
			--cfPoints;
			partySupport += .1f;
		}
		else 
		{
			//TODO alert player of lack of funds
		}

		if (legTick1.isTicked && plPoints - 1 >= 0) 
		{
			--plPoints;
			MainPage.score++;

		}
		else 
		{
			//TODO alert player of lack of funds
		}

		partySupport -= .02f;

		if (score >= 10) 
		{
			MainPage.pass10 = true;
		}

		if (score >= 20) 
		{
			MainPage.pass20 = true;
		}

		if (score >= 30) 
		{
			MainPage.pass30 = true;
		}

		turnNumber++;

		if (turnNumber >= 40) 
		{
			MainPage.office40 = true;
		}

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

		refObject = GameObject.Find("cam1");
		camTick1 = (OGTickBox)refObject.GetComponent<OGTickBox>();

		refObject = GameObject.Find("leg1");
		legTick1 = (OGTickBox)refObject.GetComponent <OGTickBox>();
	}

	private void setPointTotals()
	{
		pcLabel.text = "Political Capital: " + pcPoints;
		cfLabel.text = "Camp. Funds: " + cfPoints;
		plLabel.text = "Leverage: " + plPoints;

		supportMeter.value = partySupport;
	}


	private void endGame()
	{
		Application.LoadLevel("GameOverScene");
	}

}
