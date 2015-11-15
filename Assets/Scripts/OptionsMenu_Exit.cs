using UnityEngine;
using System.Collections;

public class OptionsMenu_Exit : MonoBehaviour {

	public void OnMouseDown () {
		Application.LoadLevel("Main_Screen");
	}
}
