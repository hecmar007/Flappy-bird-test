﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class columnPull : MonoBehaviour {

    #region Variables

    public int columnsPoolSize = 5;
    public GameObject columnPrefab;
    public float spawnRate = 4f;
    public float columnMin = -1f;
    public float columnMax = 3.5f;

    private GameObject[] columns;
    private Vector2 objectPoolPosition = new Vector2(-15f, -25f);
    private float timeSinceLastSpawned;
    private float spawnXPosition = 10f;
    private int currentColumn = 0;
	#endregion

	void Start ()
	{
        columns = new GameObject[columnsPoolSize];
        for (int i = 0; i < columnsPoolSize; i++)
        {
            columns[i] = (GameObject)Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity);
        }
	}

	void Update ()
	{
        timeSinceLastSpawned += Time.deltaTime;

        if(!gameController.instance.gameOver && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0;
            float spawnYPosition = Random.Range(columnMin, columnMax);
            columns[currentColumn].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            currentColumn++;
            if(currentColumn >= columnsPoolSize)
            {
                currentColumn = 0;
            }
        }
	}
}
