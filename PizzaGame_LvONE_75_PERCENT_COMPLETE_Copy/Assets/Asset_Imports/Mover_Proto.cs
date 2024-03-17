using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover_Proto : MonoBehaviour
{
    // Define variables
    public float amplitude = 5.0f; // Amount of oscillation
    public float frequency = 1.0f; // Speed of oscillation
    public float movingSpeed = 1.0f;

    private float initialX;

    // Use this for initialization
    void Start()
    {
        initialX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        float offset = Mathf.Sin(Time.time * frequency) * amplitude;
        Vector3 newPosition = transform.position;
        newPosition.x = initialX + offset;
        transform.position = newPosition;

        // Move forward
        transform.Translate(Vector3.right * movingSpeed * Time.deltaTime);
    }
}