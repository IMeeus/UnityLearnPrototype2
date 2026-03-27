using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnManager : MonoBehaviour
{
    private readonly float _spawnRangeX = 20;
    private readonly float _spawnPositionZ = 20;

    public GameObject[] animalPrefab;
    public InputActionReference spawnAnimalAction;

    void Update()
    {
        if (spawnAnimalAction.action.WasPressedThisFrame())
        {
            SpawnAnimal();
        }
    }

    private void SpawnAnimal()
    {
        var animalIndex = Random.Range(0, animalPrefab.Length);
        var animalToSpawn = animalPrefab[animalIndex];
        var spawnPos = new Vector3(Random.Range(-_spawnRangeX, _spawnRangeX), 0, _spawnPositionZ);

        Instantiate(animalToSpawn, spawnPos, animalToSpawn.transform.rotation);
    }
}
