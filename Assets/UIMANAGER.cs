using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public Animator startButton;
    public Animator settingsButton;
    public void OpenSettings()
    {
        startButton.SetBool("isHidden", true);
        settingsButton.SetBool("isHidden", true);
        dialog.SetBool("isHidden", false);
    }


    public void StartGame()
    {
        SceneManager.LoadScene("RocketMouse");
    }

    public Animator dialog;


    public void CloseSettings()
    {
        startButton.SetBool("isHidden", false);
        settingsButton.SetBool("isHidden", false);
        dialog.SetBool("isHidden", true);
    }

    public Animator gearImage;
    public Animator contentPanel;
    public void ToggleMenu()
    {
        bool isHidden = contentPanel.GetBool("isHidden");
        contentPanel.SetBool("isHidden", !isHidden);

        {
            //..skipped..

            gearImage.SetBool("isHidden", !isHidden);
        }
    }
}
