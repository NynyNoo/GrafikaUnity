using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameControlerZadanie : MonoBehaviour
{
    [SerializeField] GameObject[] coins;
    [SerializeField] GameObject textCoinGameObject;
    [SerializeField] GameObject textTimeGameObject;
    [SerializeField] GameObject resultGameObject;
    [SerializeField] GameObject player;
    [SerializeField] GameObject button;
    Vector2 startingPos;
    TextMeshProUGUI coinMesh;
    TextMeshProUGUI timeMesh;
    TextMeshProUGUI resultMesh;
    public Transform playerStartingPosition;
    float timer=3;
    int coinAmount = 0;
    public bool gameIsRunning = true;
    private void Start()
    {
        coinMesh = textCoinGameObject.GetComponent<TextMeshProUGUI>();
        timeMesh = textTimeGameObject.GetComponent<TextMeshProUGUI>();
        resultMesh = resultGameObject.GetComponent<TextMeshProUGUI>();
        coinMesh.text = "Monety: 0";
        startingPos = playerStartingPosition.position;
    }
    public void UpdateCoinValue(int value)
    {
        coinAmount+= value;
        coinMesh.text = $"Wynik: {coinAmount}";
    }
    private void FixedUpdate()
    {
        if(gameIsRunning)
        {
            UpdateGame();
        }
    }
    void UpdateGame()
    {
        if (Math.Round(timer) <= 0)
            EndGame();
        timer -= Time.deltaTime;

        timeMesh.text = $"Pozostały czas: {Math.Round(timer)}";
    }
    void EndGame()
    {
        gameIsRunning = false;
        resultGameObject.SetActive(true);
        button.SetActive(true);
        resultMesh.text = $"Koniec gry: {coinAmount}pkt.";
    }
    public void RestartGame()
    {
        foreach (var item in coins)
        {
            item.SetActive(true);
            player.transform.position = startingPos;
            timer = 60;
            coinAmount = 0;
            resultGameObject.SetActive(false);
            button.SetActive(false);
            gameIsRunning = true;
        }
    }
}
