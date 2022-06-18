using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StuckPowerUp : MonoBehaviour, PowerUp
{
    [SerializeField] Movement player;
    void PowerUp.ChangeValues()
    {
        player.move = false;
        Destroy(this.gameObject);
    }

}
