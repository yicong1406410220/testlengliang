using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    //public static List<MapC> pileList;

    // Use this for initialization
    void Start()
    {
        if (GameDate.pileList == null)
        {
            Loadjson();
        }
        if (GameDate.pileList == null)
        {
            GameDate.poss = new bool[4];
            for (int i = 0; i < GameDate.poss.Length; i++)
            {
                GameDate.poss[i] = false;
            }


        }
        


        //SceneManager.GetSceneByName;
    }

    /// <summary>
    /// 加载json里面的数据
    /// </summary>
    private void Loadjson()
    {
        string json = Resources.Load<TextAsset>("json/pcard").text;
        MuchCard muchCard = JsonMapper.ToObject<MuchCard>(json);
        GameDate.pileList = new List<MapC>();
        foreach (Person a in muchCard.persons)
        {
            GameDate.pileList.Add(a);
        }
        foreach (Prop a in muchCard.props)
        {
            GameDate.pileList.Add(a);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
