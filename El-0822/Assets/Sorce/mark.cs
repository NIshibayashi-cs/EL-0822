using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mark : MonoBehaviour
{
    public Sprite maru_;     // 〇画像
    public Sprite bathu_;    // ×画像

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 正解
    public void Seikai()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = maru_;
    }

    // 不正解
    public void Husekikai()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = bathu_;
    }
}
