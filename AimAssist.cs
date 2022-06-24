using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class AimAssist : MonoBehaviour
{
    [SerializeField] private float speed;
    public GameObject player;
    public Transform jumpPoint;
    public Vector2 direction;
    public float jumpForce;



    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    public bool isTouchingGround;

    public GameObject OptionBt;


    public GameObject CheckpointPanel;


    void Update()
    {
        transform.Rotate(0, 0, 360 * Time.deltaTime);
        direction = transform.right;

        if (Input.touchCount > 0 || Input.GetKey(KeyCode.Space) && CheckpointPanel.activeSelf == false)
        {          
            player.GetComponent<Rigidbody2D>().velocity = direction * jumpForce;
        }

    }

}