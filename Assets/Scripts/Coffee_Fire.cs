using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Coffee_Fire : MonoBehaviour {
					//All this mess is just to figure out where the coffee is to be shot from.
	public GameObject Weapon;
	public GameObject Source;
	GameObject clone;
	int n, i, j;
	void Start() {
		if(gameObject.name.Contains("1")){
			n = 1;
			i = 0;
		}
		if(gameObject.name.Contains("2")){
			n = 2;
			i = 2;
		}
		Source = GameObject.Find (string.Format ("Player{0}Source",n));
		Weapon = Resources.Load ("Weapon_Coffee", typeof(GameObject)) as GameObject;
	}
	void Update () {
		if (GameObject.Find ("Main Camera").GetComponent<TouchControls> ().player1Fire && n == 1) {
			//Debug.Log ("Source is " + Source.gameObject.name);
			clone = Instantiate (Weapon, Source.transform.position, Source.transform.rotation) as GameObject;
			Coffee_Collider.Source = "Player1";
			clone.name = "Wpn_Coffee0";
			Debug.Log ("coffee is live");
			clone.gameObject.rigidbody2D.AddRelativeForce (Vector2.right * 1000);
			Inventory1.PlayerItems.Pop (); //Remove the top item in the stack
			Destroy (this);
		}

		if (GameObject.Find ("Main Camera").GetComponent<TouchControls> ().player2Fire && n == 2) {
			//Debug.Log ("Source is " + Source.gameObject.name);
			clone = Instantiate (Weapon, Source.transform.position, Source.transform.rotation) as GameObject;
			Coffee_Collider.Source = "Player2";
			clone.name = "Wpn_Coffee2";
			Debug.Log ("coffee is live");
			clone.gameObject.rigidbody2D.AddRelativeForce (Vector2.right * 1000);
			Inventory2.PlayerItems.Pop();
			Destroy (this);
		}


	}
}
