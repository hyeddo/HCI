using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class saveNotice : MonoBehaviour
{
    public Canvas Notice1;
    public Canvas Notice2;

    // Start is called before the first frame update
    void Start()
    {
        Notice1.enabled = false;
        Notice2.enabled = false;
    }

    public void click1()
    {
        Notice1.enabled = true;
    }

    public void click2()
    {
        Notice2.enabled = true;
    }

    public void clear()
    {
        Notice1.enabled = false;
        Notice2.enabled = false;
    }
}
