#pragma strict
 
var sounds : AudioClip[];
function QuitGame() {				
	Debug.Log("can't quit from editor");
	Application.Quit();
}

function ExitGame() {				
	Application.LoadLevel("Main_Screen");
}

function SelectSportsCar(){
	Debug.Log("SportsCar is selected for player1.");
	PlayerPrefs.SetString("Player1Choice", "Car_Sports");
	PlayerPrefs.SetString("Player1Source", "SportsCar_Src");
	PlayerPrefs.SetString("Player1Source2", "SportsCar_Src2");
	PlayerPrefs.SetInt("Player1Conf", 0);
	PlayerPrefs.SetFloat("Player1Speed", 2.0f);
	PlayerPrefs.SetFloat("Player1Rotation", 0.9f);
	PlayerPrefs.SetInt("Player1MaxHits", 3);
	AudioSource.PlayClipAtPoint(sounds[0],transform.position);
}

function SelectSedan(){
	Debug.Log("Sedan is selected for player1.");
	PlayerPrefs.SetString("Player1Choice", "Car_Sedan");
	PlayerPrefs.SetString("Player1Source", "Sedan_Src");
	PlayerPrefs.SetString("Player1Source2", "Sedan_Src2");
	PlayerPrefs.SetInt("Player1Conf", 2);
	PlayerPrefs.SetFloat("Player1Speed", 1.25f);
	PlayerPrefs.SetFloat("Player1Rotation", 1.2f);
	PlayerPrefs.SetInt("Player1MaxHits", 5);
	AudioSource.PlayClipAtPoint(sounds[1],transform.position);
}

function SelectSUV(){
	Debug.Log("SUV is selected for player1.");
	PlayerPrefs.SetString("Player1Choice", "Car_SUV");
	PlayerPrefs.SetString("Player1Source", "SUV_Src");
	PlayerPrefs.SetString("Player1Source2", "SUV_Src2");
	PlayerPrefs.SetInt("Player1Conf", 2);
	PlayerPrefs.SetFloat("Player1Speed", 0.95f);
	PlayerPrefs.SetFloat("Player1Rotation", 1.5f);
	PlayerPrefs.SetInt("Player1MaxHits", 7);
	AudioSource.PlayClipAtPoint(sounds[2],transform.position);
}

function LoadStart1() {
	Application.LoadLevel("Start_Screen");
}
function LoadStart2() {
	StartCoroutine(Load2());
}
function Load2() {
	yield WaitForSeconds(1);
	Application.LoadLevel("Start_Screen2");
}

function LoadOptions() {
	Application.LoadLevel("Options");
}

function MainMenu() {
	Application.LoadLevel("Start_Screen");
}
function Update() {
		if(Input.GetKeyDown("escape")) {
			Debug.Log ("can't quit from editor");
				Application.Quit(); 
		}
}
