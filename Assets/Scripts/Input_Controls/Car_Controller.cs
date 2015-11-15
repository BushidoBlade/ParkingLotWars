using UnityEngine;
using System.Collections;

public class Car_Controller : MonoBehaviour {

	public AudioClip[] sounds;
	GameObject audiosrc;

	public float speed = 0.0f;
	public float rotationSpeed = 0.0f;
	public int Max_Hits = 5;
	public float moveUp = 0.0f;
	public float moveDown = 0.0f;
	public float rotateLeft = 0.0f;
	public float rotateRight = 0.0f;
	//Player_Inputs _inputs;
	GameObject Spawn;
	public double counter = 0;
	int index1;
	public void Reset(){
				if (counter == Max_Hits) {
						AudioSource.PlayClipAtPoint (sounds [1], audiosrc.transform.position);
				} else if (counter != Max_Hits) {
						AudioSource.PlayClipAtPoint (sounds [0], audiosrc.transform.position);
				}
				Debug.Log (gameObject.name + "'s health ran out!");
				gameObject.transform.position = Spawn.transform.position;
				gameObject.transform.rotation = Spawn.transform.rotation;
				gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
				counter = 0;
	}

	void Start() {
		//_inputs = GetComponent<Player_Inputs> ();
		if (gameObject.name == "Player1") {
			//player = 1;
			Spawn = GameObject.Find ("Spawn_P1");
			speed = PlayerPrefs.GetFloat ("Player1Speed");
			rotationSpeed = PlayerPrefs.GetFloat ("Player1Rotation");
			Max_Hits = PlayerPrefs.GetInt("Player1MaxHits");
			index1 = 1;
		}
		else if (gameObject.name == "Player2") {
			//player = 2;
			Spawn = GameObject.Find ("Spawn_P2");
			speed = PlayerPrefs.GetFloat ("Player2Speed");
			rotationSpeed = PlayerPrefs.GetFloat ("Player2Rotation");
			Max_Hits = PlayerPrefs.GetInt("Player2MaxHits");
			index1 = 2;
		}
		audiosrc = GameObject.Find ("audiosource");
	}
	
	void OnCollisionEnter2D(Collision2D col) {
		
		if(col.gameObject.name.Contains("Player")){
			counter++;
			//Debug.Log (counter + "hits for " + gameObject.name);
		}
		
		if (counter == Max_Hits) {
			Reset ();
		}
	}

	void FixedUpdate () {
			if (moveUp != 0 || moveDown != 0)
				AudioSource.PlayClipAtPoint (sounds [2], audiosrc.transform.position, 0.3f);
			//float translation = _inputs.y * speed;
			float rotationL = rotateLeft * rotationSpeed;
			float rotationR = rotateRight * rotationSpeed;

			float rotation = rotationL - rotationR;

			//transform.Translate (-translation, 0, 0);

			// -transform.right is the forward direction on car
			rigidbody2D.AddForce(-transform.right * moveUp * speed);
			rigidbody2D.AddForce(transform.right * moveDown * speed);
			transform.Rotate (0, 0, rotation);
	}

}
