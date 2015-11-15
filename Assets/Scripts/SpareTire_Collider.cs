using UnityEngine;
using System.Collections;

public class SpareTire_Collider : MonoBehaviour {

	public static GameObject target;
	int n;
	Rigidbody2D body;
	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.name == target.name) { 
			Debug.Log (col.gameObject.name + " ran into a spare tire!");
			GameObject spwn;
			if(col.gameObject.name.Contains("1")) {
				n = 1;
				body = GameObject.Find ("Player1").GetComponent<Rigidbody2D>();
			}
			if(col.gameObject.name.Contains("2")) {
				n = 2;
				body = GameObject.Find ("Player2").GetComponent<Rigidbody2D>();
			}
			string tmp;
			tmp = string.Format("Spawn_P{0}", n);
			spwn = GameObject.Find (tmp);
			col.audio.Play ();
			col.transform.position = spwn.transform.position;
			col.transform.rotation = spwn.transform.rotation;
			body.velocity = Vector2.zero;
		}
		Destroy (gameObject);
	}
}
