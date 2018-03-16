using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboutTween : MonoBehaviour {

    public Ease ease = Ease.OutBack;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UiOpen()
    {    
        gameObject.SetActive(true);
        transform.localScale = new Vector3(0, 0, 1);
        Tweener tweener = transform.DOScale(new Vector3(1, 1, 1), 1);
        tweener.SetEase(ease);
    }

    public void UiExit()
    {
        transform.localScale = new Vector3(1, 1, 1);
        Tweener tweener = transform.DOScale(new Vector3(0, 0, 1), 1);
        tweener.SetEase(ease);
        tweener.OnComplete(() => gameObject.SetActive(false));
    }

}
