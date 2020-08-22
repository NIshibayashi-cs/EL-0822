using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public float countTime_;
    public int time_;
    public GameObject count_;

    // Start is called before the first frame update
    void Start()
    {
        countTime_ = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        countTime_ += Time.deltaTime;
        if(countTime_ >= time_)
        {
            gameObject.GetComponent<Text>().text = "0";
            PlayerPrefs.SetInt("Score", count_.GetComponent<countText>().GetCount());
            SceneManager.LoadSceneAsync("result");

        }
        gameObject.GetComponent<Text>().text = "" + (time_ - (int)countTime_);
    }
}
