using UnityEngine;
using System.Collections;

public class changeSkyBox : MonoBehaviour {

	// Use this for change frames
	public void changeFrame (Material input) {
		RenderSettings.skybox = input;
	}
}