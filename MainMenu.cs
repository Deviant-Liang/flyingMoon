using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject MainSettingPanel;


    public GameObject CreditsPanel;


    void Awake()
    {

        
    }




    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SettingPanel()
    {
        MainSettingPanel.SetActive(true);
    }

    public void BackToSetting()
    {
        MainSettingPanel.SetActive(false);
    }

    


    public void CreditsBt()
    {
        CreditsPanel.SetActive(true);
    }

    public void BackToSettings()
    {
        CreditsPanel.SetActive(false);

    }

}
