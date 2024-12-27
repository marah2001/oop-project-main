using UnityEngine;

public class RotatingColoredSphere : MonoBehaviour
{
    public float rotationSpeed = 10f;
    public Color[] colors;

    private int colorIndex;
    private Vector3 rotationAxis;

    void Start()
    {
        // تهيئة اللون المحفوظ حالياً ومحور الدوران
        colorIndex = 0;
        rotationAxis = Random.insideUnitSphere;
    }

    void Update()
    {
        // الدوران حول المحور
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);

        // تغيير اللون عند الضغط على زر الإدخال
        if (Input.GetKeyDown(KeyCode.Return))
        {
            colorIndex = (colorIndex + 1) % colors.Length;
            GetComponent<Renderer>().material.color = colors[colorIndex];

            // تغيير محور الدوران عشوائياً
            rotationAxis = Random.insideUnitSphere;
        }
    }
}