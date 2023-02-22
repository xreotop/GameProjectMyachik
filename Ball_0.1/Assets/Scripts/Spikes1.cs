using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes1 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == BallController2.Instance.gameObject)
        {
            BallController2.Instance.GetDamage();
        }
    }
}
