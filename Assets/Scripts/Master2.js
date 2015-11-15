#pragma strict

var sounds : AudioClip[];

function QuitGame() {
	Debug.Log("can't quit from editor");				
	Application.Quit();
}
	function SelectSportsCar(){
	Debug.Log("SportsCar is selected for player2.");
	PlayerPrefs.SetString("Player2Choice", "Car_Sports");
	PlayerPrefs.SetString("Player2Source", "SportsCar_Src");
	PlayerPrefs.SetString("Player2Source2", "SportsCar_Src2");
	PlayerPrefs.SetInt("Player2Conf", 0);
	PlayerPrefs.SetFloat("Player2Speed", 2.0f);
	PlayerPrefs.SetFloat("Player2Rotation", 0.7f);
	PlayerPrefs.SetInt("Player2MaxHits", 3);
	AudioSource.PlayClipAtPoint(sounds[0],transform.position);
}

function SelectSedan(){
	Debug.Log("Sedan is selected for player2.");
	PlayerPrefs.SetString("Player2Choice", "Car_Sedan");
	PlayerPrefs.SetString("Player2Source", "Sedan_Src");
	PlayerPrefs.SetString("Player2Source2", "Sedan_Src2");
	PlayerPrefs.SetInt("Player2Conf", 2);
	PlayerPrefs.SetFloat("Player2Speed", 1.25f);
	PlayerPrefs.SetFloat("Player2Rotation", 1.0f);
	PlayerPrefs.SetInt("Player2MaxHits", 5);
	AudioSource.PlayClipAtPoint(sounds[1],transform.position);
}

function SelectSUV(){
	Debug.Log("SUV is selected for player2.");
	PlayerPrefs.SetString("Player2Choice", "Car_SUV");
	PlayerPrefs.SetString("Player2Source", "SUV_Src");
	PlayerPrefs.SetString("Player2Source2", "SUV_Src2");
	PlayerPrefs.SetInt("Player2Conf", 2);
	PlayerPrefs.SetFloat("Player2Speed", 0.75f);
	PlayerPrefs.SetFloat("Player2Rotation", 1.5f);
	PlayerPrefs.SetInt("Player2MaxHits", 7);
	AudioSource.PlayClipAtPoint(sounds[2],transform.position);
}
function StartGame() {
	StartCoroutine(LoadStart());
}
function LoadStart() {
	yield WaitForSeconds(1);
	Application.LoadLevel("Level_1");
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