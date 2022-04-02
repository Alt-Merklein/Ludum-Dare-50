using UnityEngine;

public class MoonMovement : MonoBehaviour
{
    public float rotationSpeed;
    void Update()
    {
        gameObject.GetComponent<RectTransform>().localRotation *= Quaternion.Euler(0,0, rotationSpeed * Time.deltaTime);
    }
}
