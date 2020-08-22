using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hanntei : MonoBehaviour
{
    public int frameCount_;

    // Start is called before the first frame update
    void Start()
    {
        frameCount_ = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(frameCount_ == 180)
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }

        frameCount_++;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // 一文字とチェックを照合
        if(other.gameObject.GetComponent<obj>().ichimoji_ == other.gameObject.GetComponent<obj>().check_)
        {
            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<mark>().Seikai();
            transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<countText>().CountUp();
        }
        else
        {
            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<mark>().Husekikai();
        }

        // ふきだしだす
        transform.GetChild(0).gameObject.SetActive(true);
        frameCount_ = 0;

        //当たったオブジェクトを消す
        Destroy(other.gameObject);
    }
}
