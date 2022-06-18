using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DOTweenTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("´­¸²");
            StartCoroutine(spin());
        }
    }

    IEnumerator spin()
    {
        yield return null;
        transform.DOScale(new Vector3(1.2f,1.2f,1.2f), 0.5f).SetEase(Ease.OutSine).SetLoops(-1, LoopType.Yoyo);

    }
}
