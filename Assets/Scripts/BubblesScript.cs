using System;
using UnityEngine;

public class BubblesScript : MonoBehaviour
{
    [SerializeField] private int score;
    
    private void OnMouseDown()
    {
        GameManager.Instance.AddScore(score);
        Destroy(gameObject);
    }
}
