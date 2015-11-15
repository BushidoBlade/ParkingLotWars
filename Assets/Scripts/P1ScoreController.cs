using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class P1ScoreController : MonoBehaviour {
	public Text player1ScoreText;
	// Use this for initialization
	void Start () {
		player1ScoreText = GameObject.Find ("P1Score").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		player1ScoreText.text = "Score:" + GameObject.Find("ToolBox1").GetComponent<Inventory1>().P1Score;
	}
}
