using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReversiPower : MonoBehaviour, PowerUp
{
    [SerializeField] Movement player;
    void PowerUp.ChangeValues()
    {
        player.controls = false;
        Destroy(this.gameObject);
    }
}
