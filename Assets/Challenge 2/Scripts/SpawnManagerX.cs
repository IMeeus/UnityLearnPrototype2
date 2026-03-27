using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private readonly float _spawnLimitXLeft = -22;
    private readonly float _spawnLimitXRight = 7;
    private readonly float _spawnPosY = 30;
    private readonly float _startDelay = 1.0f;
    private readonly float _spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomBall), _startDelay, _spawnInterval);
    }

    void SpawnRandomBall ()
    {
        var spawnPos = new Vector3(Random.Range(_spawnLimitXLeft, _spawnLimitXRight), _spawnPosY, 0);
        var ballIndex = Random.Range(0, ballPrefabs.Length);
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[0].transform.rotation);
    }

}
