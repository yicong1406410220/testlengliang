using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class Texttextload : MonoBehaviour {

    public Text text;

	// Use this for initialization
	void Start () {
        string path = Application.persistentDataPath + "/aa/BBa.txt";
        Directory.CreateDirectory(Application.persistentDataPath + "/aa");
        File.WriteAllText(path, "per保佑这个也能读取成功啊~~hello??", Encoding.UTF8);
        //File.ReadAllText(path, Encoding.UTF8);
        string  s = File.ReadAllText(path, Encoding.UTF8) + "\n" + path;
        text.text = s;
        File.WriteAllText("aas", "ass保佑这个也能读取成功啊~~hello??", Encoding.UTF8);
        string sd = File.ReadAllText("aas", Encoding.UTF8) + "\n" + path;
        text.text += "\n" + sd;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
