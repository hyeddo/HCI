using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pick23 : MonoBehaviour
{
    public Canvas pick2;
    public Canvas pick3;
    public Canvas cancel;

    public void pickTwo()
    {
        pick2.enabled = true;
        cancel.enabled = false;
        pick3.enabled = false;
    }

    public void pickThree()
    {
        pick3.enabled = true;
        cancel.enabled = false;
        pick2.enabled = false;
    }
}
