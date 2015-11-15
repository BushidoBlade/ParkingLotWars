using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsMenu_Antialiasing : MonoBehaviour {
	public Text Antialiasing;

	void Awake () {
		Antialiasing = GameObject.Find ("AntialiasingText").GetComponent<Text>();
		if(QualitySettings.antiAliasing == 0) {
			Antialiasing.text = "Antialiasing: Off";
		}
		else if(QualitySettings.antiAliasing == 2){
			Antialiasing.text = "Antialiasing: 2x";
		}
		else if(QualitySettings.antiAliasing == 4){
			Antialiasing.text = "Antialiasing: 4x";
		}
		else if(QualitySettings.antiAliasing == 8){
			Antialiasing.text = "Antialiasing: 8x";
		}
	}

	public void OnMouseDown () {
		if(QualitySettings.antiAliasing == 8) {
			QualitySettings.antiAliasing = 0;
			Antialiasing.text = "Antialiasing: Off";
		}
		else if(QualitySettings.antiAliasing == 0){
			QualitySettings.antiAliasing = 2;
			Antialiasing.text = "Antialiasing: 2x";
		}
		else if(QualitySettings.antiAliasing == 2){
			QualitySettings.antiAliasing = 4;
			Antialiasing.text = "Antialiasing: 4x";
		}
		else if(QualitySettings.antiAliasing == 4){
			QualitySettings.antiAliasing = 8;
			Antialiasing.text = "Antialiasing: 8x";
		}
	}
}
