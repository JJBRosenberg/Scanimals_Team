using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class loadImages : MonoBehaviour {
 
	// Use this for initialization
	IEnumerator Start () {
		WWW www = new WWW ("file:///D://Unity//Scanimals//Parrot_Pictures.png");
		while(!www.isDone)
			yield return null;
		GameObject image = GameObject.Find ("RawImage");
		image.GetComponent<RawImage>().texture = www.texture;
	}
}




