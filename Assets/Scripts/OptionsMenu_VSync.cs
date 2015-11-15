using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsMenu_VSync : MonoBehaviour {
	public Text vSync;
	void Awake (){
		vSync = GameObject.Find ("vSyncText").GetComponent<Text>();
		if(QualitySettings.vSyncCount == 0){
			vSync.text = "vSync: Off";
		}
		else{
			vSync.text = "vSync: On";
		}
	}


	public void OnMouseDown () {
		if(QualitySettings.vSyncCount == 1){
			QualitySettings.vSyncCount = 0;
			vSync.text = "vSync: Off";
		}
		else if(QualitySettings.vSyncCount == 0){
			QualitySettings.vSyncCount = 1;
			vSync.text = "vSync: On";
		}
	}
}
