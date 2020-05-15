using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotoPick : MonoBehaviour
{
    public Image photos;
    public Image[] photoArray = new Image[50];
    private bool picked = false;

    void Start()
    {
        GameManager.instance.pickedNum = 0;
    }

    public void pickPhoto()
    {
        if (picked == false)
        {
            photos.GetComponent<Image>().color = new Color(0.5f, 0.5f, 0.5f);
            picked = true;
            GameManager.instance.pickedNum += 1;
            if(GameManager.instance.pickedNum==1)
                GameManager.instance.picked1 = photos;
            else if (GameManager.instance.pickedNum == 2)
                GameManager.instance.picked2 = photos;
            else if (GameManager.instance.pickedNum == 3)
                GameManager.instance.picked3 = photos;
            else if (GameManager.instance.pickedNum == 4)
                GameManager.instance.picked4 = photos;
            else if (GameManager.instance.pickedNum == 5)
                GameManager.instance.picked5 = photos;
            else if (GameManager.instance.pickedNum == 6)
                GameManager.instance.picked6 = photos;
            else if (GameManager.instance.pickedNum == 7)
                GameManager.instance.picked7 = photos;
            else if (GameManager.instance.pickedNum == 8)
                GameManager.instance.picked8 = photos;
            else if (GameManager.instance.pickedNum == 9)
                GameManager.instance.picked9 = photos;
            else if (GameManager.instance.pickedNum == 10)
                GameManager.instance.picked10 = photos;
            else if (GameManager.instance.pickedNum == 11)
                GameManager.instance.picked11 = photos;
            else if (GameManager.instance.pickedNum == 12)
                GameManager.instance.picked12 = photos;
            else if (GameManager.instance.pickedNum == 13)
                GameManager.instance.picked13 = photos;
            else if (GameManager.instance.pickedNum == 14)
                GameManager.instance.picked14 = photos;
            else if (GameManager.instance.pickedNum == 15)
                GameManager.instance.picked15 = photos;
            else if (GameManager.instance.pickedNum == 16)
                GameManager.instance.picked16 = photos;
            else if (GameManager.instance.pickedNum == 17)
                GameManager.instance.picked17 = photos;
            else if (GameManager.instance.pickedNum == 18)
                GameManager.instance.picked18 = photos;
            else if (GameManager.instance.pickedNum == 19)
                GameManager.instance.picked19 = photos;
            else if (GameManager.instance.pickedNum == 20)
                GameManager.instance.picked20 = photos;
            else if (GameManager.instance.pickedNum == 21)
                GameManager.instance.picked21 = photos;
            else if (GameManager.instance.pickedNum == 22)
                GameManager.instance.picked22 = photos;
            else if (GameManager.instance.pickedNum == 23)
                GameManager.instance.picked23 = photos;
            else if (GameManager.instance.pickedNum == 24)
                GameManager.instance.picked24 = photos;
            else if (GameManager.instance.pickedNum == 25)
                GameManager.instance.picked25 = photos;
            else if (GameManager.instance.pickedNum == 26)
                GameManager.instance.picked26 = photos;
            else if (GameManager.instance.pickedNum == 27)
                GameManager.instance.picked27 = photos;
            else if (GameManager.instance.pickedNum == 28)
                GameManager.instance.picked28 = photos;
            else if (GameManager.instance.pickedNum == 29)
                GameManager.instance.picked29 = photos;
            else if (GameManager.instance.pickedNum == 30)
                GameManager.instance.picked30 = photos;
            else if (GameManager.instance.pickedNum == 31)
                GameManager.instance.picked31 = photos;
            else if (GameManager.instance.pickedNum == 32)
                GameManager.instance.picked32 = photos;
            else if (GameManager.instance.pickedNum == 33)
                GameManager.instance.picked33 = photos;
            else if (GameManager.instance.pickedNum == 34)
                GameManager.instance.picked34 = photos;
            else if (GameManager.instance.pickedNum == 35)
                GameManager.instance.picked35 = photos;
            else if (GameManager.instance.pickedNum == 36)
                GameManager.instance.picked36 = photos;
            else if (GameManager.instance.pickedNum == 37)
                GameManager.instance.picked37 = photos;
        }
        else if (picked == true)
        {
            photos.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f);
            picked = false;
            GameManager.instance.pickedNum -= 1;
        }
    }

}
