using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tourna3Photo : MonoBehaviour
{
    public Button[] button = new Button[3];
    public Button[] winButton = new Button[3];
    public GameObject progress;
    private Image[] photoArr = new Image[38];
    private int inx;
    private int currPhoto;
    private Image firstPhoto;
    private Image secondPhoto;
    private Image thirdPhoto;
    private bool isFirst;
    private int backupNum;
    private int backupCurNum;
    private int backupInx;
    private Image[] backup = new Image[38];
    private float percent;
    private float cnt;
    private int fixedNum;
    public Canvas EndGame;
    public Canvas start;

    // Start is called before the first frame update
    void Start()
    {
        EndGame.enabled = false;

        photoArr[1] = GameManager.instance.picked1; photoArr[2] = GameManager.instance.picked2; photoArr[3] = GameManager.instance.picked3; photoArr[4] = GameManager.instance.picked4; photoArr[5] = GameManager.instance.picked5;
        photoArr[6] = GameManager.instance.picked6; photoArr[7] = GameManager.instance.picked7; photoArr[8] = GameManager.instance.picked8; photoArr[9] = GameManager.instance.picked9; photoArr[10] = GameManager.instance.picked10;
        photoArr[11] = GameManager.instance.picked11; photoArr[12] = GameManager.instance.picked12; photoArr[13] = GameManager.instance.picked13; photoArr[14] = GameManager.instance.picked14; photoArr[15] = GameManager.instance.picked15;
        photoArr[16] = GameManager.instance.picked16; photoArr[17] = GameManager.instance.picked17; photoArr[18] = GameManager.instance.picked18; photoArr[19] = GameManager.instance.picked19; photoArr[20] = GameManager.instance.picked20;
        photoArr[21] = GameManager.instance.picked21; photoArr[22] = GameManager.instance.picked22; photoArr[23] = GameManager.instance.picked23; photoArr[24] = GameManager.instance.picked24; photoArr[25] = GameManager.instance.picked25;
        photoArr[26] = GameManager.instance.picked26; photoArr[27] = GameManager.instance.picked27; photoArr[28] = GameManager.instance.picked28; photoArr[29] = GameManager.instance.picked29; photoArr[30] = GameManager.instance.picked30;
        photoArr[31] = GameManager.instance.picked31; photoArr[32] = GameManager.instance.picked32; photoArr[33] = GameManager.instance.picked33; photoArr[34] = GameManager.instance.picked34; photoArr[35] = GameManager.instance.picked35;
        photoArr[36] = GameManager.instance.picked36; photoArr[37] = GameManager.instance.picked37;

        currPhoto = 1;
        inx = 1;
        isFirst = true;
        cnt = 0.0f;
        fixedNum = GameManager.instance.pickedNum;

        button[0].GetComponent<Image>().sprite = photoArr[currPhoto].sprite;
        button[1].GetComponent<Image>().sprite = photoArr[currPhoto + 1].sprite;
        button[2].GetComponent<Image>().sprite = photoArr[currPhoto + 2].sprite;
    }

    public void tourna1()
    {
        cnt++;

        for (int i = 1; i <= GameManager.instance.pickedNum; i++)//배열 백업
        {
            backup[i] = photoArr[i];
        }

        for (int i = 1; i <= GameManager.instance.pickedNum; i++)
        {
            if (button[0].GetComponent<Image>().sprite == photoArr[i].sprite)
            {
                photoArr[inx] = photoArr[i];
                inx++;
            }
        }

        currPhoto += 3;

        if (currPhoto > GameManager.instance.pickedNum)//다음 사진이 없으면 다음 라운드로 이동
        {
            backupCurNum = currPhoto;
            backupInx = inx;
            backupNum = GameManager.instance.pickedNum;

            currPhoto = 1;
            inx = 1;
            isFirst = false;

            if (GameManager.instance.pickedNum % 3 == 0)
                GameManager.instance.pickedNum = GameManager.instance.pickedNum / 3;
        }

        else if (currPhoto + 1 > GameManager.instance.pickedNum)//다음 사진이 한 장 남았을 때 앞에 두장 땡겨써
        {
            backupCurNum = currPhoto;
            backupInx = inx;
            backupNum = GameManager.instance.pickedNum;

            currPhoto -= 2;
            isFirst = false;
        }

        else if (currPhoto + 2 > GameManager.instance.pickedNum)//다음 사진이 두 장 남았을 때 앞에 한장 땡겨서
        {
            backupCurNum = currPhoto;
            backupInx = inx;
            backupNum = GameManager.instance.pickedNum;

            currPhoto -= 1;
            isFirst = false;
        }

        if (GameManager.instance.pickedNum != 1 && inx > 1)
        {
            button[0].GetComponent<Image>().sprite = photoArr[currPhoto].sprite;//다음 사진들 띄워주기
            button[1].GetComponent<Image>().sprite = photoArr[currPhoto + 1].sprite;
            button[2].GetComponent<Image>().sprite = photoArr[currPhoto + 2].sprite;
        }

        else
        {
            winButton[0].GetComponent<Image>().sprite = photoArr[1].sprite;
            winButton[1].GetComponent<Image>().sprite = photoArr[2].sprite;
            winButton[2].GetComponent<Image>().sprite = photoArr[currPhoto + 2].sprite;
            EndGame.enabled = true;
        }
    }

    public void tourna2()
    {
        cnt++;

        for (int i = 1; i <= GameManager.instance.pickedNum; i++)//배열 백업
        {
            backup[i] = photoArr[i];
        }

        for (int i = 1; i <= GameManager.instance.pickedNum; i++)
        {
            if (button[1].GetComponent<Image>().sprite == photoArr[i].sprite)
            {
                photoArr[inx] = photoArr[i];
                inx++;
            }
        }

        currPhoto += 3;

        if (currPhoto > GameManager.instance.pickedNum)//다음 사진이 없으면 다음 라운드로 이동
        {
            backupCurNum = currPhoto;
            backupInx = inx;
            backupNum = GameManager.instance.pickedNum;

            currPhoto = 1;
            inx = 1;
            isFirst = false;

            if (GameManager.instance.pickedNum % 3 == 0)
                GameManager.instance.pickedNum = GameManager.instance.pickedNum / 3;
        }

        else if (currPhoto + 1 > GameManager.instance.pickedNum)//다음 사진이 한 장 남았을 때 앞에 두장 땡겨써
        {
            backupCurNum = currPhoto;
            backupInx = inx;
            backupNum = GameManager.instance.pickedNum;

            currPhoto -= 2;
            isFirst = false;
        }

        else if (currPhoto + 2 > GameManager.instance.pickedNum)//다음 사진이 두 장 남았을 때 앞에 한장 땡겨서
        {
            backupCurNum = currPhoto;
            backupInx = inx;
            backupNum = GameManager.instance.pickedNum;

            currPhoto -= 1;
            isFirst = false;
        }

        if (GameManager.instance.pickedNum != 1 && inx > 1)
        {
            button[0].GetComponent<Image>().sprite = photoArr[currPhoto].sprite;//다음 사진들 띄워주기
            button[1].GetComponent<Image>().sprite = photoArr[currPhoto + 1].sprite;
            button[2].GetComponent<Image>().sprite = photoArr[currPhoto + 2].sprite;
        }

        else
        {
            winButton[0].GetComponent<Image>().sprite = photoArr[1].sprite;
            winButton[1].GetComponent<Image>().sprite = photoArr[2].sprite;
            winButton[2].GetComponent<Image>().sprite = photoArr[currPhoto + 2].sprite;
            EndGame.enabled = true;
        }
    }

    public void tourna3()
    {
        cnt++;

        for (int i = 1; i <= GameManager.instance.pickedNum; i++)//배열 백업
        {
            backup[i] = photoArr[i];
        }

        for (int i = 1; i <= GameManager.instance.pickedNum; i++)
        {
            if (button[2].GetComponent<Image>().sprite == photoArr[i].sprite)
            {
                photoArr[inx] = photoArr[i];
                inx++;
            }
        }

        currPhoto += 3;

        if (currPhoto > GameManager.instance.pickedNum)//다음 사진이 없으면 다음 라운드로 이동
        {
            backupCurNum = currPhoto;
            backupInx = inx;
            backupNum = GameManager.instance.pickedNum;

            currPhoto = 1;
            inx = 1;
            isFirst = false;

            if (GameManager.instance.pickedNum % 3 == 0)
                GameManager.instance.pickedNum = GameManager.instance.pickedNum / 3;
        }

        else if (currPhoto + 1 > GameManager.instance.pickedNum)//다음 사진이 한 장 남았을 때 앞에 두장 땡겨써
        {
            backupCurNum = currPhoto;
            backupInx = inx;
            backupNum = GameManager.instance.pickedNum;

            currPhoto -= 2;
            isFirst = false;
        }

        else if (currPhoto + 2 > GameManager.instance.pickedNum)//다음 사진이 두 장 남았을 때 앞에 한장 땡겨서
        {
            backupCurNum = currPhoto;
            backupInx = inx;
            backupNum = GameManager.instance.pickedNum;

            currPhoto -= 1;
            isFirst = false;
        }

        if (GameManager.instance.pickedNum != 1 && inx > 1)
        {
            button[0].GetComponent<Image>().sprite = photoArr[currPhoto].sprite;//다음 사진들 띄워주기
            button[1].GetComponent<Image>().sprite = photoArr[currPhoto + 1].sprite;
            button[2].GetComponent<Image>().sprite = photoArr[currPhoto + 2].sprite;
        }

        else
        {
            winButton[0].GetComponent<Image>().sprite = photoArr[1].sprite;
            winButton[1].GetComponent<Image>().sprite = photoArr[2].sprite;
            winButton[2].GetComponent<Image>().sprite = photoArr[currPhoto + 2].sprite;
            EndGame.enabled = true;
        }
    }

    public void previous()
    {
        cnt--;

        if (currPhoto == 1 && inx == 1 && isFirst == false)
        {
            GameManager.instance.pickedNum = backupNum;
            currPhoto = backupCurNum;
            inx = backupInx;

        }
        else if (currPhoto == 1 && inx == 1)
        {
            SceneManager.LoadScene("Tournament");
        }

        currPhoto -= 3;
        inx--;
        button[0].GetComponent<Image>().sprite = backup[currPhoto].sprite;//다음 사진들 띄워주기
        button[1].GetComponent<Image>().sprite = backup[currPhoto + 1].sprite;
        button[2].GetComponent<Image>().sprite = backup[currPhoto + 2].sprite;
        for (int i = 1; i <= GameManager.instance.pickedNum; i++)
        {
            photoArr[i] = backup[i];
        }
    }

    public void Progress()
    {
        percent = cnt / (float)(fixedNum - 1);
        percent *= 100.0f;
        progress.GetComponent<Transform>().localScale = new Vector3(0.02f, 1.0f, (percent / 100.0f) * 0.3f);
        progress.GetComponent<Transform>().position = new Vector3(-1.5f + (percent / 100.0f) * 3f * 0.5f, 6.11f, -0.5f);
    }
}
