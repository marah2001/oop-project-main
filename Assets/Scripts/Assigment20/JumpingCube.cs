using UnityEngine;


public class JumpingCube : MonoBehaviour
{ public float scaleSpeed = 2f;
    private bool isScalingUp = true;
    private Color originalColor;

    void Start()
    {
        // حفظ اللون الأصلي للمكعب
        originalColor = GetComponent<Renderer>().material.color;
    }

    void Update()
    {
        // التحقق من النقر بزر الماوس الأيسر
        if (Input.GetMouseButtonDown(0))
        {
            isScalingUp = !isScalingUp;

            if (isScalingUp)
            {
                // تغيير اللون إلى الأزرق
                GetComponent<Renderer>().material.color = Color.blue;
            }
            else
            {
                // إعادة اللون الأصلي
                GetComponent<Renderer>().material.color = originalColor;
            }
        }

        // تكبير أو تصغير المكعب تدريجياً
        transform.localScale += Vector3.one * (isScalingUp ? scaleSpeed : -scaleSpeed) * Time.deltaTime;
    }
}