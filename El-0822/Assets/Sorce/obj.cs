using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class obj : MonoBehaviour
{
    public bool ichimoji_;  // 一文字か
    public bool check_;     // チェック
    public float speed_;    // 速度
    public string name_;    // 名前

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x -= speed_;
        transform.position = pos;
    }

    // クリックイベント
    public void OnSortiePointClick(BaseEventData data)
    {
        check_ = !check_;
        transform.GetChild(0).gameObject.SetActive(check_);
    }
}
