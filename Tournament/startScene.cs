using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startScene : MonoBehaviour
{
    public Canvas startCanvas;
    public Canvas notice;
    public Canvas Gallery;
    public Canvas notice2;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        startCanvas.enabled = true;
        notice.enabled = false;
        Gallery.enabled = false;
        notice2.enabled = false;
        time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= 2.0f && time<4.0f)
        {
            startCanvas.enabled = false;
            Gallery.enabled = true;
            notice.enabled = true;

        }
        if (time >= 4.0f)
            notice.enabled = false;
    }

    public void notice2up()
    {
        notice2.enabled = true;
    }
}
