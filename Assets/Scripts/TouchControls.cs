using UnityEngine;
using System.Collections;

public class TouchControls : MonoBehaviour {

	public bool player1Fire = false;
	public bool player2Fire = false;
	public bool p1moveup = false;
	public bool p1movedown = false;
	public bool p1turnleft = false;
	public bool p1turnright = false;

	public bool p2moveup = false;
	public bool p2movedown = false;
	public bool p2turnleft = false;
	public bool p2turnright = false;

	public float forwardLimiter = 0.5f;
	public float reverseLimiter = 0.25f;
	public float turnLimiter = 2.0f;

	public void movep1Up(){
		//GameObject.Find ("Player1").GetComponent<Car_Controller>().moveUp = 1.0f;
		p1moveup = true;
	}
	public void movep1UpEnd(){
		//GameObject.Find ("Player1").GetComponent<Car_Controller>().moveUp = 0.0f;
		p1moveup = false;
	}
	public void movep1Down(){
		//GameObject.Find ("Player1").GetComponent<Car_Controller>().moveDown = 1.0f;
		p1movedown = true;
	}
	public void movep1DownEnd(){
		//GameObject.Find ("Player1").GetComponent<Car_Controller>().moveDown = 0.0f;
		p1movedown = false;
	}
	public void rotatep1Left(){
		//GameObject.Find ("Player1").GetComponent<Car_Controller>().rotateLeft = 2.0f;
		p1turnleft = true;
	}
	public void rotatep1LeftEnd(){
		//GameObject.Find ("Player1").GetComponent<Car_Controller>().rotateLeft = 0.0f;
		p1turnleft = false;
	}
	public void rotatep1Right(){
		//GameObject.Find ("Player1").GetComponent<Car_Controller>().rotateRight = 2.0f;
		p1turnright = true;
	}
	public void rotatep1RightEnd(){
		//GameObject.Find ("Player1").GetComponent<Car_Controller>().rotateRight = 0.0f;
		p1turnright = false;
	}
	public void firep1(){
		player1Fire = true;
	}
	public void firep1End(){
		player1Fire = false;
	}


	public void movep2Up(){
		//GameObject.Find ("Player2").GetComponent<Car_Controller>().moveUp = 1.0f;
		p2moveup = true;
	}
	public void movep2UpEnd(){
		//GameObject.Find ("Player2").GetComponent<Car_Controller>().moveUp = 0.0f;
		p2moveup = false;
	}
	public void movep2Down(){
		//GameObject.Find ("Player2").GetComponent<Car_Controller>().moveDown = 1.0f;
		p2movedown = true;
	}
	public void movep2DownEnd(){
		//GameObject.Find ("Player2").GetComponent<Car_Controller>().moveDown = 0.0f;
		p2movedown = false;
	}
	public void rotatep2Left(){
		//GameObject.Find ("Player2").GetComponent<Car_Controller>().rotateLeft = 2.0f;
		p2turnleft = true;
	}
	public void rotatep2LeftEnd(){
		//GameObject.Find ("Player2").GetComponent<Car_Controller>().rotateLeft = 0.0f;
		p2turnleft = false;
	}
	public void rotatep2Right(){
		//GameObject.Find ("Player2").GetComponent<Car_Controller>().rotateRight = 2.0f;
		p2turnright = true;
	}
	public void rotatep2RightEnd(){
		//GameObject.Find ("Player2").GetComponent<Car_Controller>().rotateRight = 0.0f;
		p2turnright = false;
	}
	public void firep2(){
		player2Fire = true;
	}
	public void firep2End(){
		player2Fire = false;
	}

	void FixedUpdate(){
		// player 1 joystick simulation
		if (p1moveup) {
			GameObject.Find ("Player1").GetComponent<Car_Controller> ().moveUp = 1500;
		} else {
			GameObject.Find ("Player1").GetComponent<Car_Controller>().moveUp = 0;
		}

		if (p1movedown){
			GameObject.Find ("Player1").GetComponent<Car_Controller>().moveDown = 750;
		} else {
			GameObject.Find ("Player1").GetComponent<Car_Controller>().moveDown = 0;
		}

		//if (p1turnleft && (p1moveup || p1movedown)){
		if (p1turnleft){
			GameObject.Find ("Player1").GetComponent<Car_Controller>().rotateLeft = 1;
		} else {
			GameObject.Find ("Player1").GetComponent<Car_Controller>().rotateLeft = 0;
		}

		//if (p1turnright && (p1moveup || p1movedown)){
		if (p1turnright){
			GameObject.Find ("Player1").GetComponent<Car_Controller>().rotateRight = 1;
		} else {
			GameObject.Find ("Player1").GetComponent<Car_Controller>().rotateRight = 0;
		}

		// player 2 joystick simulation
		if (p2moveup){
			GameObject.Find ("Player2").GetComponent<Car_Controller>().moveUp = 1500;
		} else {
			GameObject.Find ("Player2").GetComponent<Car_Controller>().moveUp = 0;
		}

		if (p2movedown){
			GameObject.Find ("Player2").GetComponent<Car_Controller>().moveDown = 750;
		} else {
			GameObject.Find ("Player2").GetComponent<Car_Controller>().moveDown = 0;
		}

		//if (p2turnleft && (p2moveup || p2movedown)){
		if (p2turnleft){
			GameObject.Find ("Player2").GetComponent<Car_Controller>().rotateLeft = 1;
		} else {
			GameObject.Find ("Player2").GetComponent<Car_Controller>().rotateLeft = 0;
		}

		//if (p2turnright && (p2moveup || p2movedown)){
		if (p2turnright){
			GameObject.Find ("Player2").GetComponent<Car_Controller>().rotateRight = 1;
		} else {
			GameObject.Find ("Player2").GetComponent<Car_Controller>().rotateRight = 0;
		}
	}
}
