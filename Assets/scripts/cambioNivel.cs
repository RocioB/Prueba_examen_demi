using UnityEngine;
using System.Collections;

public class cambioNivel : MonoBehaviour {
	public string namelevel;


	public void pasarnivelpollas(){

		Application.LoadLevel (namelevel);


	}
}
