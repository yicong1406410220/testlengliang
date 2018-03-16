using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestIn : MonoBehaviour
{

    public Transform[] poss;
    public GameObject go;

    // Use this for initialization
    void Start()
    {
        Instantiate(go, GameObject.Find("pos").transform.TransformPoint(poss[1].position),Quaternion.identity).transform.SetParent(GameObject.Find("Canvas").transform);
        Instantiate(go, poss[1].position, Quaternion.identity);
        Instantiate(go, poss[2].position, Quaternion.identity);
        Instantiate(go, poss[3].position, Quaternion.identity);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
