using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

public class ObjectGenerator : MonoBehaviour
{
    
    [SerializeField] private float spawnTime = 0.5f;
    [SerializeField] private GameObject[] prefabs;

    private readonly int[] _probability = {0, 1, 0, 1, 2, 0, 0, 1, 0, 2};
    
    private void OnEnable()
    {
        StartCoroutine(SpawnRoutine());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    private IEnumerator SpawnRoutine()
    {
        while (isActiveAndEnabled)
        {
            yield return new WaitForSeconds(spawnTime);
            Spawn();
        }
    }
    
    private void Spawn()
    {
        var prefab = prefabs[_probability[(int) (Random.value * _probability.Length)]];
        if (!prefab) 
            return;
        
        var position = new Vector3(
            Random.Range(-2f, 2f),
            Random.Range(-4f, 4f), 
            0f);
        
        var rotation = new Quaternion();
        
        Instantiate(prefab, position, rotation);
    }
}