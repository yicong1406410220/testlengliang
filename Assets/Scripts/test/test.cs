using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Tweener tweener = this.gameObject.transform.DOScale(new Vector3(0,0,0), 5f).From();
        //Debug.Log("你好");
        //tweener.SetEase(Ease.InBack);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UiOpen()
    {
        gameObject.transform.localScale = new Vector3(0, 0, 0);
        Tweener tweener = gameObject.transform.DOScale(new Vector3(1, 1, 1), 2f);
        
    }

    public void UiClose()
    {
        gameObject.transform.localScale = new Vector3(1, 1, 1);
        Tweener tweener = this.gameObject.transform.DOScale(new Vector3(0, 0, 0), 2f);
        tweener.OnComplete(() => Debug.Log("hello word"));
    }
    
    public void UiYiDong()
    {
        gameObject.transform.position = new Vector3(1, 1, 1);
        this.gameObject.transform.DOMove(new Vector3(100, 100, 0), 20f);
        this.gameObject.transform.DOMoveY(100, 20f);
 

    }

}
