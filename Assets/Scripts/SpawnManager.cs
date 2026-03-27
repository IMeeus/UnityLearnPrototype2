using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnManager : MonoBehaviour
{
    private readonly float _spawnRangeX = 20;
    private readonly float _spawnPositionZ = 20;
    private readonly float _startDelay = 2.0f;
    private readonly float _spawnInterval = 1.5f;

    public GameObject[] animalPrefab;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnAnimal), _startDelay, _spawnInterval);
    }

    private void SpawnAnimal()
    {
        var animalIndex = Random.Range(0, animalPrefab.Length);
        var animalToSpawn = animalPrefab[animalIndex];
        var spawnPos = new Vector3(Random.Range(-_spawnRangeX, _spawnRangeX), 0, _spawnPositionZ);

        Instantiate(animalToSpawn, spawnPos, animalToSpawn.transform.rotation);
    }
}
