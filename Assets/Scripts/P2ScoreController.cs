using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class P2ScoreController : MonoBehaviour {
	public Text player2ScoreText;
	// Use this for initialization
	void Start () {
		player2ScoreText = GameObject.Find ("P2Score").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		player2ScoreText.text = "Score:" + GameObject.Find("ToolBox2").GetComponent<Inventory2>().P2Score;
	}
}

