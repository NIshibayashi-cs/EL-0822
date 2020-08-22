using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    public GameObject[] prehub_;
    public int frameCount_;
    private int createCount_;

    // Start is called before the first frame update
    void Start()
    {
        frameCount_ = 0;
        createCount_ = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (frameCount_ % (1000 - System.Math.Min(createCount_ * 60 , 600)) == 0)
        {
            GameObject o;
            o = Instantiate(prehub_[Random.Range(0, prehub_.Length)], new Vector3(15.0f, 0.0f, 1.0f), Quaternion.identity);
            o.gameObject.GetComponent<obj>().speed_ = 0.02f + System.Math.Min((float)createCount_ * 0.001f, 0.1f);
            createCount_++;
        }

        frameCount_++;
    }
}
