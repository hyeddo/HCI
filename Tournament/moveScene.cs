using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void moveToTournament()
    {
        SceneManager.LoadScene("Tournament");
    }

    public void moveToGallery()
    {
        SceneManager.LoadScene("Gallery");
    }
}
