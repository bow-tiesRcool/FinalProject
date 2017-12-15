using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour {

	public GameObject play;
	public GameObject credits;
	public GameObject quit;
	public GameObject creditsInfo;

	public void ChangeInfo()
	{
			play.gameObject.SetActive(false);
			credits.gameObject.SetActive(false);
			quit.gameObject.SetActive(false);
			creditsInfo.gameObject.SetActive(true);
	}

	public void Close()
	{
		play.gameObject.SetActive(true);
		credits.gameObject.SetActive(true);
		quit.gameObject.SetActive(true);
		creditsInfo.gameObject.SetActive(false);
	}
}
