using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowController : MonoBehaviour
{
    [SerializeField] private float growScale = 0.1f;
    [SerializeField] private float growTime = 1f;
    
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
        yield return new WaitForSeconds(growTime);
        gameObject.transform.localScale += new Vector3(growScale,growScale,growScale);
    }
}
