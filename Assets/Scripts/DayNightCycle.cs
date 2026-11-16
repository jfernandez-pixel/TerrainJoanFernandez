using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DayNightCycle : MonoBehaviour
{
    public Light _light;
    public float _rotationSpeed = 1.2f;

    public void Update()
    {
        _light.transform.Rotate(Vector3.right, _rotationSpeed * Time.deltaTime);
    }
}
