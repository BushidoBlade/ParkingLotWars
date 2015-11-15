using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		GameObject music;
		music = GameObject.Find ("Music");
		Destroy (music);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
