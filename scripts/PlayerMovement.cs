using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;

    public AudioSource DeathSFX;

    public GameObject arrow;
    public bool isDead = false;


    private Vector3 respawnPoint;
    public GameObject DeathDector;
    public Vector2 direction = Vector2.down;

    public GameObject OptionBt;
    public GameObject CompletePanel;




    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        respawnPoint = transform.position;
    }

    private void Update()
    {
        arrow.transform.position = transform.TransformPoint(0, 0, 0);
             
    }
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "DeathDector")
        {
            GetComponent<SpriteRenderer>().enabled = false;
            arrow.GetComponent<SpriteRenderer>().enabled = false;
            if(SaveManager.instance.SFX == true)
            {
                DeathSFX.Play();
            }
            body.bodyType = RigidbodyType2D.Static;




            StartCoroutine("RestartGameCo");
        }

        if (collision.tag == "Platform")
        {
            transform.parent = collision.gameObject.transform;
        }

        if (collision.tag == "Checkpoint")
        {
            respawnPoint = collision.transform.position;
        }

        if (collision.tag == "Complete")
        {
            OptionBt.SetActive(false);
            CompletePanel.SetActive(true);
        }

    }

    public IEnumerator RestartGameCo()
    {
        yield return new WaitForSeconds(1);
        transform.position = respawnPoint;
        GetComponent<SpriteRenderer>().enabled = true;
        arrow.GetComponent<SpriteRenderer>().enabled = true;
        body.Sleep();
        body.bodyType = RigidbodyType2D.Dynamic;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            transform.parent = null;
        }
    }

}
