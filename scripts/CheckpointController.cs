using UnityEngine;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class CheckpointController : MonoBehaviour
{

    public Sprite falseFlag;
    public Sprite trueFlag;
    private SpriteRenderer checkpointSpriteRenderer;
    public bool checkpointReached;

    public int checkpoints;



    // Use this for initialization
    void Start()
    {
        checkpointSpriteRenderer = GetComponent<SpriteRenderer>();
        checkpoints = SaveManager.instance.checkpoints;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(SaveManager.instance.checkpoints == 0)
        {
            checkpointSpriteRenderer.sprite = falseFlag;
            checkpointReached = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        checkpoints = SaveManager.instance.checkpoints;



        if (other.tag == "Player")
        {
            if (checkpointSpriteRenderer.sprite != trueFlag)
            {
                checkpoints++;

            }
            checkpointSpriteRenderer.sprite = trueFlag;
            checkpointReached = true;
        }

        SaveManager.instance.checkpoints = checkpoints;

        SaveManager.instance.Save();
    }


}