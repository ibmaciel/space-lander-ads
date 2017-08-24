using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestAd : MonoBehaviour {

//	private Button watchVideoAdBtn;
	private Button fuelRewardBtn;

	void Start () {
//		watchVideoAdBtn = GameObject.Find("WatchVideoAdBtn").GetComponent<Button>();
//		watchVideoAdBtn.onClick.AddListener(AdManager.instance.ShowStandardVideoAd);

		fuelRewardBtn = GameObject.Find("MoreFuelRewardAdBtn").GetComponent<Button>();
		fuelRewardBtn.onClick.AddListener(AdManager.instance.ShowRewardedFuelVideoAd);
	}
}
