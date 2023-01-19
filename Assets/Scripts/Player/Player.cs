using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed;
    public float runSpeed;

    private Vector2 direction;
    private float initialSpeed;
    private Rigidbody2D rig;

    private bool isRunning;

    public GameObject Inventory;
    

    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        this.initialSpeed = Speed;
        Inventory.SetActive(false);
    }

    
    void Update()
    {
        OnInput();
        OnRun();
        OpenInventory();
    }

    void FixedUpdate()
    {
        OnMove();
    }

    private void OpenInventory()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Inventory.SetActive(true);
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Inventory.SetActive(false);
        }
    }

    #region Movement

    private void OnInput()
    {
        direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    private void OnMove()
    {
        if (direction != Vector2.zero)
        {
            rig.MovePosition(rig.position + direction * Speed * Time.deltaTime);
        }
    }

    private void OnRun()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Speed = runSpeed;
            isRunning = true;
        } 
        
        if (Input.GetKeyUp(KeyCode.LeftShift)) 
        {
            Speed = initialSpeed;
            isRunning = false;
        }
    }

    #endregion
}
