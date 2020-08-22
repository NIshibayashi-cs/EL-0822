using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countText : MonoBehaviour
{
    private int count_;  // 正解カウント

    // Start is called before the first frame update
    void Start()
    {
        count_ = 0;
        gameObject.GetComponent<Text>().text = "" + count_;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // カウントアップ
    public void CountUp()
    {
        count_++;
        gameObject.GetComponent<Text>().text = "" + count_;
    }

    // カウントダウン
    public void CountDown()
    {
        count_--;
        gameObject.GetComponent<Text>().text = "" + count_;
    }
}
