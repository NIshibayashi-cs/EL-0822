using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resultCount : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Text>().text = "" + PlayerPrefs.GetInt("Score", 0);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
