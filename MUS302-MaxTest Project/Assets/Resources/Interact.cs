using UnityEngine;
using System.Collections;

public class Interact : MonoBehaviour {

    protected bool viewedOn;
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
    protected void setTime()
    {
        if (viewedOn)
        {
            time += Time.deltaTime;
        }
        else
        {
            time -= Time.deltaTime;
        }
        time = Mathf.Clamp01(time);

        if (time >= 1)
        {
            SubmitAction();
            time = 0;
        }
    }
    protected virtual void SubmitAction()
    {
        print("Action Submitted");
    }

    void Update()
    {
        setTime();


    }
}
