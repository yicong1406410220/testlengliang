using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using UnityEngine.SceneManagement;
using System;
using DG.Tweening;

public class GameController : MonoBehaviour
{

    public Transform[] ps;

    public GameObject mCard;

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
    /// 检测是否有空位置
    /// </summary>
    private void CheckPos()
    {
        for (int i = 1; i < GameDate.poss.Length; i++)
        {
            if (GameDate.poss[i] == false && GameDate.isPlay == false)
            {
                GameDate.isPlay = true;
                Deal(ps[i].position);
                GameDate.poss[i] = true;
                break;
            }
        }
    }

    /// <summary>
    /// 发牌
    /// </summary>
    /// <param name="end"></param>
    private void Deal(Vector3 end)
    {
        GameObject go = Instantiate<GameObject>(mCard,new Vector3(20, 20, 0),Quaternion.identity);
        int index = UnityEngine.Random.Range(0, GameDate.pileList.Count);
        MapC mapC = GameDate.pileList[index];
        GameDate.pileList.RemoveAt(index);
        MapCard mapCard = go.GetComponent<MapCard>();
        mapCard.Name = mapC.name;
        mapCard.Sprite = Resources.Load<Sprite>("img/" + mapC.imagePath);
        mapCard.Nature = mapC.nature;
        Tweener tweener = go.transform.DOMove(end, 2f);
        tweener.OnComplete(() => { GameDate.isPlay = false;});
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
        for (int i = 0; i < GameDate.pileList.Count; i++)
        {

            int index = UnityEngine.Random.Range(0, GameDate.pileList.Count);
            if (index != i)
            {
                MapC temp = GameDate.pileList[i];
                GameDate.pileList[i] = GameDate.pileList[index];
                GameDate.pileList[index] = temp;
            }
        }

        for (int i = 0; i < GameDate.pileList.Count; i++)
        {
            Debug.Log(GameDate.pileList[i].name);

        }
    }

    // Update is called once per frame
    void Update()
    {
        CheckPos();
    }
}
