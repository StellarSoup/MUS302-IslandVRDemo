using UnityEngine;
using System.Collections;

public class TestingSphere : MonoBehaviour {

    bool viewedOn;
    public float time;
    void Start()
    {
        time = 0;
        viewedOn = false;
    }
    public void SetView(bool state)
    {
        viewedOn = state;
    }

    void Update()
    {
        if (viewedOn)
        {
            time += Time.deltaTime;
        }else
        {
            time -= Time.deltaTime;
        }
        time = Mathf.Clamp01(time);

        if(time >= 1)
        {
            print("Action Submitted");
            time = 0;
        }
        

    }
}
