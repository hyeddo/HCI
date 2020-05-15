using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class numOfPhotos : MonoBehaviour
{
    public Text numText;
    private float num;
    
    // Update is called once per frame
    void Update()
    {
        num = GameManager.instance.pickedNum;
        numText.text = num.ToString();
    }
}
