using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class downtween : MonoBehaviour {

    public Ease ease = Ease.OutBack;

	// Use this for initialization
	void Start () {
        Tweener tweener = transform.DOLocalMoveY(500, 4).From();
        tweener.SetEase(ease);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
