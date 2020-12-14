using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMAINMENU : MonoBehaviour
{
    public Animator myanimator;

    public void StartGame()
    {
        SceneManager.LoadScene("MidtermProject");
    }

    public void Hidbutton()
    {
        myanimator.SetBool("ISH", true);
        Invoke("StartGame", 1.0f);
    }
}
