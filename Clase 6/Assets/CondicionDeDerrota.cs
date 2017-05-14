using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CondicionDeDerrota : MonoBehaviour {

	private Scene escena;
	private bool condicionDeDerrota;

	void Start () {
		escena = SceneManager.GetActiveScene ();
		condicionDeDerrota = false;
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Piso" && condicionDeDerrota) {
			Application.LoadLevel (escena.name);
		}
		condicionDeDerrota = true;
	}
}
