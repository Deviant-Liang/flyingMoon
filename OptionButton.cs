using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SceneManagement;


public class OptionButton : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject MainPanel;
    public GameObject OptionPanel;
    public GameObject OptionBt;
    public GameObject CheckpointPanel;  
    public GameObject MainSettingPanel;
    public GameObject ResetPanel;
    public GameObject BackToMenuPanel;
    public GameObject CompletePanel;

    public GameObject Checkpoint;
    public GameObject Checkpoint1;
    public GameObject Checkpoint2;
    public GameObject Checkpoint3;
    public GameObject Checkpoint4;
    public GameObject Checkpoint5;
    public GameObject Checkpoint6;
    public GameObject Checkpoint7;


    public GameObject CPBt;
    public GameObject CP1Bt;
    public GameObject CP2Bt;
    public GameObject CP3Bt;
    public GameObject CP4Bt;
    public GameObject CP5Bt;
    public GameObject CP6Bt;
    public GameObject CP7Bt;


    //Checkpoints

    public GameObject Player;




    void Awake()
    {
        Time.timeScale = 1f;
    }

    void FixedUpdate()
    {
        if (SaveManager.instance.checkpoints >= 1) CPBt.SetActive(true);
        else CPBt.SetActive(false);
        if (SaveManager.instance.checkpoints >= 2) CP1Bt.SetActive(true);
        else CP1Bt.SetActive(false);
        if (SaveManager.instance.checkpoints >= 3) CP2Bt.SetActive(true);
        else CP2Bt.SetActive(false);
        if (SaveManager.instance.checkpoints >= 4) CP3Bt.SetActive(true);
        else CP3Bt.SetActive(false);
        if (SaveManager.instance.checkpoints >= 5) CP4Bt.SetActive(true);
        else CP4Bt.SetActive(false);
        if (SaveManager.instance.checkpoints >= 6) CP5Bt.SetActive(true);
        else CP5Bt.SetActive(false);
        if (SaveManager.instance.checkpoints >= 7) CP6Bt.SetActive(true);
        else CP6Bt.SetActive(false);
        if (SaveManager.instance.checkpoints >= 8) CP7Bt.SetActive(true);
        else CP7Bt.SetActive(false);


    }


    public void OptionMenu()
    {
        Time.timeScale = 0f;
        OptionPanel.SetActive(true);
        OptionBt.SetActive(false);
        GameIsPaused = true;       
    }

    public void BackToGame()
    {
        OptionPanel.SetActive(false);
        OptionBt.SetActive(true);
        GameIsPaused = false;
        Time.timeScale = 1f;
    }


    public void BackToMenuBt()
    {
        BackToMenuPanel.SetActive(true);
    }

    public void DontGoback()
    {
        BackToMenuPanel.SetActive(false);
    }


    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
        MainSettingPanel.SetActive(false);
        OptionPanel.SetActive(false);
        Time.timeScale = 0f;
    }

    public void ChooseCheckpoint()
    {
        OptionPanel.SetActive(false);
        CheckpointPanel.SetActive(true);
    }

    public void BackToOption()
    {
        CheckpointPanel.SetActive(false); 
        OptionPanel.SetActive(true);
    }

    public void PlayGame()
    {
        OptionBt.SetActive(true);
        MainPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void SettingPanel()
    {
        OptionBt.SetActive(false);
        MainPanel.SetActive(false);
        MainSettingPanel.SetActive(true);
    }

    public void BackToSetting()
    {
        MainSettingPanel.SetActive(false);
        MainPanel.SetActive(true);
    }

    public void CP()
    {
        CheckpointPanel.SetActive(false);
        Player.GetComponent<Rigidbody2D>().Sleep();
        OptionBt.SetActive(true);
        Time.timeScale = 1f;
    }

    public void CP1()
    {
        CheckpointPanel.SetActive(false);
        OptionBt.SetActive(true);
        Player.transform.position = Checkpoint1.transform.position;
        Time.timeScale = 1f;
    }

    public void CP2()
    {
        CheckpointPanel.SetActive(false);
        OptionBt.SetActive(true);
        Player.transform.position = Checkpoint2.transform.position;
        Time.timeScale = 1f;
    }

    public void CP3()
    {
        CheckpointPanel.SetActive(false);
        OptionBt.SetActive(true);
        Player.transform.position = Checkpoint3.transform.position;
        Time.timeScale = 1f;
    }

    public void CP4()
    {
        CheckpointPanel.SetActive(false);
        OptionBt.SetActive(true);
        Player.transform.position = Checkpoint4.transform.position;
        Time.timeScale = 1f;
    }

    public void CP5()
    {
        CheckpointPanel.SetActive(false);
        OptionBt.SetActive(true);
        Player.transform.position = Checkpoint5.transform.position;
        Time.timeScale = 1f;
    }

    public void CP6()
    {
        CheckpointPanel.SetActive(false);
        OptionBt.SetActive(true);
        Player.transform.position = Checkpoint6.transform.position;
        Time.timeScale = 1f;
    }

    public void CP7()
    {
        CheckpointPanel.SetActive(false);
        OptionBt.SetActive(true);
        Player.transform.position = Checkpoint7.transform.position;
        Time.timeScale = 1f;
    }

    public void ResetBt()
    {
        ResetPanel.SetActive(true);
    }

    public void Reset()
    {
        SaveManager.instance.checkpoints = 0;
        SaveManager.instance.Save();
        CPBt.SetActive(false);
        CP1Bt.SetActive(false);
        CP2Bt.SetActive(false);
        CP3Bt.SetActive(false);
        CP4Bt.SetActive(false);
        CP5Bt.SetActive(false);
        CP6Bt.SetActive(false);
        CP7Bt.SetActive(false);
        ResetPanel.SetActive(false);
    }

    public void NoBt()
    {
        ResetPanel.SetActive(false);
    }

    public void Hack()
    {
        SaveManager.instance.checkpoints = 8;
        SaveManager.instance.Save();
        CPBt.SetActive(true);
        CP1Bt.SetActive(true);
        CP2Bt.SetActive(true);
        CP3Bt.SetActive(true);
        CP4Bt.SetActive(true);
        CP5Bt.SetActive(true);
        CP6Bt.SetActive(true);
        CP7Bt.SetActive(true);
    }

    public void Complete()
    {
        OptionBt.SetActive(true);
        CompletePanel.SetActive(false);
        SceneManager.LoadScene(0);
    }





}
