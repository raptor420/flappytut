using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour {
    public int ColumnPoolSize = 5;
    public GameObject columnPrefab;
    public float spawnRate = 4f;
    public float ColumnMin = -1f;
    public float ColumnMax = 3.5f;

    private GameObject[] columns;
    private Vector2 objecPoolPosition = new Vector2(-15f, -25f);
    private float timeSinceLastSpawned;
    private float spawnXPosition = 12f;
    private int currenColumn = 0;
	// Use this for initialization
	void Start () {

        columns = new GameObject[ColumnPoolSize];
        for (int i = 0; i<ColumnPoolSize; i++)
        {
            columns[i] = (GameObject)Instantiate(columnPrefab, objecPoolPosition, Quaternion.identity);
        }
		
	}
	
	// Update is called once per frame
	void Update () {
        timeSinceLastSpawned += Time.deltaTime;
        if(GameController.instance.gameover ==false && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0;
            float spawnYPostion = Random.Range(ColumnMin, ColumnMax);
            columns[currenColumn].transform.position = new Vector2(spawnXPosition, spawnYPostion);
            currenColumn++;
            if(currenColumn >= ColumnPoolSize)
            {
                currenColumn = 0;
            }

        }
	}
}
