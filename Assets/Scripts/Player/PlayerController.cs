using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PlayerController : MonoBehaviour, ISaveable
{
    public Rigidbody2D rb;
    private float moveX;
    public float moveSpeed;
    public Animator animator;

    public WorldState worldState;
    public TMP_Text cointTxt;

    void Awake()
    {
        if (worldState != null)
            worldState.increaseBalance(500f);

        updateBalance();

    }

    public void updateBalance()
    {
        Debug.Log(worldState);
        Debug.Log(cointTxt);

        if (cointTxt != null && worldState != null)
            cointTxt.text = worldState.getBalance().ToString();
    }

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F5))
        {
            print("save F5");
            //Debug.Log("QuickSave");
            //SaveLoadSystem.quickSave();
            new SaveLoadSystem().save();
        }

        if (Input.GetKeyDown(KeyCode.F8))
        {
            Debug.Log("save f8");
            new SaveLoadSystem().load();
            //saveSystem.quickLoad();
        }

        moveX = Input.GetAxisRaw("Horizontal");

        animator.SetBool("walk", moveX != 0);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveX * moveSpeed, 0);
        bool moveHorizontaly = Mathf.Abs(rb.velocity.x) > Mathf.Epsilon;
        if (moveHorizontaly)
        {
            transform.localScale = new Vector2(Mathf.Sign(rb.velocity.x), 1);
        }

    }

    public object saveState()
    {
        return new SaveData()
        {
            x = this.transform.position.x,
            y = this.transform.position.y,
            z = this.transform.position.z
        };
    }

    public void loadState(object state)
    {
        var saveData = (SaveData)state;
        rb.transform.position = new Vector3(saveData.x, saveData.y, saveData.z);
    }

    [Serializable]
    private struct SaveData
    {
        public float x;
        public float y;
        public float z;
    }

    public void moveUp(Transform elev)
    {

        rb.transform.position = new Vector3(elev.position.x, elev.position.y - 0.54f, elev.position.z);
    }
}
