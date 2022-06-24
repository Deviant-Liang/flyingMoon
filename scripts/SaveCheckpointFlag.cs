using UnityEngine;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;




public class SaveCheckpointFlag : MonoBehaviour
{
    public Sprite falseFlag;
    public Sprite trueFlag;


    public GameObject CP;
    public GameObject CP1;
    public GameObject CP2;
    public GameObject CP3;
    public GameObject CP4;
    public GameObject CP5;
    public GameObject CP6;
    public GameObject CP7;
    public GameObject CP8;



    void Start()
    {
        if (SaveManager.instance.checkpoints >= 1)
        {
            CP.GetComponent<SpriteRenderer>().sprite = trueFlag;
        }
        if (SaveManager.instance.checkpoints >= 2)
        {
            CP1.GetComponent<SpriteRenderer>().sprite = trueFlag;
        }
        if (SaveManager.instance.checkpoints >= 3)
        {
            CP2.GetComponent<SpriteRenderer>().sprite = trueFlag;
        }
        if (SaveManager.instance.checkpoints >= 4)
        {
            CP3.GetComponent<SpriteRenderer>().sprite = trueFlag;
        }
        if (SaveManager.instance.checkpoints >= 5)
        {
            CP4.GetComponent<SpriteRenderer>().sprite = trueFlag;
        }
        if (SaveManager.instance.checkpoints >= 6)
        {
            CP5.GetComponent<SpriteRenderer>().sprite = trueFlag;
        }
        if (SaveManager.instance.checkpoints >= 7)
        {
            CP6.GetComponent<SpriteRenderer>().sprite = trueFlag;
        }
        if (SaveManager.instance.checkpoints >= 8)
        {
            CP7.GetComponent<SpriteRenderer>().sprite = trueFlag;
        }
        if (SaveManager.instance.checkpoints >= 9)
        {
            CP8.GetComponent<SpriteRenderer>().sprite = trueFlag;
        }
    }
}
