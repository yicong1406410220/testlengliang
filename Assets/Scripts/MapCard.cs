using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapCard : MonoBehaviour {

    public Text text1;
    public SpriteRenderer sr;
    public Text text2;

    //public string mname;
    //public Sprite msprite;
    //public string mnature;

    
    public string Name
    {
        get { return text1.text; }
        set { text1.text = value; }
    }
    public Sprite Sprite
    {
        get { return sr.sprite; }
        set { sr.sprite = value; }
    }
    public string Nature
    {
        get { return text2.text; }
        set { text2.text = value; }
    }
    


    // Use this for initialization
    void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
        //text1.text = mname;
        //sr.sprite = msprite;
        //text2.text = mnature;
    }

    // 当用户在 GUIElement 或碰撞器上按鼠标按钮时调用 OnMouseDown
    private void OnMouseDown()
    {

    }


}
