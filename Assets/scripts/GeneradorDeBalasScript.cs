using UnityEngine;
using System.Collections;

public class GeneradorDeBalasScript : MonoBehaviour {
	
	
	public GameObject bala;
	public Transform puntoDisparo;
	public AudioClip sound;
	
	public void Fire(){
		if (bala != null) {
			var clone = Instantiate (bala, puntoDisparo.position, Quaternion.identity) as GameObject;
			clone.transform.localScale = transform.localScale;

			
		} else {
			Debug.Log("El jugador no tiene balas");
		}
	}
}