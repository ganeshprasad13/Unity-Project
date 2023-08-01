using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    private int _health;

    void Start()
    {
        _health = 5;

    }


    public void Hurt(int damage)
    {
        _health -= damage;
        UnityEngine.Debug.Log("Health :" + _health);
        if (_health == 0)
        { UnityEngine.Debug.Log("You Lost");
            Destroy(this.gameObject); }
    }
}
