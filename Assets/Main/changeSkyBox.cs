using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class changeSkyBox : MonoBehaviour {

	// Use this for change frames
	public void changeFrame (Material input) {
		RenderSettings.skybox = input;
	}

	//Use this for change SimpleText
	public void ChangeText (string input) {
		GameObject textObject = GameObject.Find("SimpleText");
		textObject.GetComponent<UnityEngine.UI.Text>().text = input;
	}

	public void disabledButton (Button input) {
		GameObject[] listButton = GameObject.FindGameObjectsWithTag ("equirectangular");
		foreach (GameObject button in listButton) {
			button.GetComponent<UnityEngine.UI.Button>().interactable = true;
		}
		input.interactable = false;
	}
}