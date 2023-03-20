using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coin : MonoBehaviour
{
    GameControlerZadanie gameControlerZadanie;
    [SerializeField] int coinValue;
    private void Awake()
    {
        gameControlerZadanie = GameObject.Find("EventSystem").GetComponent<GameControlerZadanie>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            gameControlerZadanie.UpdateCoinValue(coinValue);
            gameObject.SetActive(false);
        }
    }
}
