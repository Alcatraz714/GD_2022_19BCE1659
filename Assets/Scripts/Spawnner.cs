using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawnner : MonoBehaviour
{
    [SerializeField] private float DropTime = 5f;
    [SerializeField] private float SpawnTime = 0f;
    private MeshRenderer Renderer;
    private BoxCollider Collider;
    private float lTime;

    void Start()
    {
        lTime = Time.timeSinceLevelLoad;

        Renderer = GetComponent<MeshRenderer>();
        Renderer.enabled = false;
        Collider = GetComponent<BoxCollider>();
        Collider.enabled = false;
    }

    void Update()
    {
        lTime += Time.deltaTime;
        CheckTime();
    }

    void CheckTime()
    {
        if (lTime > SpawnTime)
        {
            Renderer.enabled = true;
            Collider.enabled = true;
        }
        if (lTime > DropTime)
        {
            Destroy(gameObject);
        }
    }
}
