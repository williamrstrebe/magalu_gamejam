using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldState : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        this.wallet = 500f;
    }

    private float wallet;

    public float getBalance() {
        return this.wallet;
    }

    public void increaseBalance(float value) {
        this.wallet += value;
    }

    public void decreaseValue(float value) {
        this.wallet -= value;
    }


}
