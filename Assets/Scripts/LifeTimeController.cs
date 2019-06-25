using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTimeController : MonoBehaviour
{
    [SerializeField] private float LifeTime = 5f;

    private void OnEnable()
    {
        StartCoroutine(KillRoutine());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    private IEnumerator KillRoutine()
    {
        yield return new WaitForSeconds(LifeTime);
        Destroy(gameObject);
    }
}
