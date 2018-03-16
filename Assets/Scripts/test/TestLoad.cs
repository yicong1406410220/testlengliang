using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestLoad : MonoBehaviour {

    public Image image;

	// Use this for initialization
	void Start () {
        //Texture2D texture2D = Resources.Load<Texture2D>("aya.png");
        image.sprite = Resources.Load<Sprite>("img/chen");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
