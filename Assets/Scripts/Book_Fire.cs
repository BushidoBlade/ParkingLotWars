using UnityEngine;
using System.Collections;

public class Book_Fire : MonoBehaviour {
				//All this mess is just to figure out where the book is to be shot from and where it's going. Once it's shot,
	public GameObject Weapon;		//the weapon itself has a script(Book_Collider) that tells it how to move.
	public GameObject Source;
	public GameObject target;
	public Transform targetTransform;
	GameObject clone;
	int n, i, j;
	void Start() {
		if(gameObject.name.Contains("1")){
			n = 1;
			i = 0;
			j = 2;
		}
		if(gameObject.name.Contains("2")){
			n = 2;
			i = 2;
			j = 1;
		}
		Source = GameObject.Find (string.Format ("Player{0}Source",n));
		Weapon = Resources.Load ("Weapon_Book", typeof(GameObject)) as GameObject;
		target = GameObject.Find (string.Format("Player{0}", j));
		targetTransform = target.transform;
	}
	void Update () {
		if (GameObject.Find ("Main Camera").GetComponent<TouchControls> ().player1Fire && n == 1) {
			//if (Input.GetButtonDown (string.Format ("Player{0}Fire", n))) { //This just spawns the book which has 
			Debug.Log ("Source is " + Source.gameObject.name); 		//its own script for its behavior.
			clone = Instantiate (Weapon, Source.transform.position, Source.transform.rotation) as GameObject;
			Book_Collider.target = targetTransform;
			clone.name = "Wpn_Book0";
			Debug.Log ("Book is live");
			Inventory1.PlayerItems.Pop(); //Remove the top item in the stack
			Destroy (this);
		}
		if (GameObject.Find ("Main Camera").GetComponent<TouchControls> ().player2Fire && n == 2) {
			//if (Input.GetButtonDown (string.Format ("Player{0}Fire", n))) { //This just spawns the book which has 
			Debug.Log ("Source is " + Source.gameObject.name); 		//its own script for its behavior.
			clone = Instantiate (Weapon, Source.transform.position, Source.transform.rotation) as GameObject;
			Book_Collider.target = targetTransform;
			clone.name = "Wpn_Book2";
			Debug.Log ("Book is live");
			Inventory2.PlayerItems.Pop();
			Destroy (this);
		}
	}
}
