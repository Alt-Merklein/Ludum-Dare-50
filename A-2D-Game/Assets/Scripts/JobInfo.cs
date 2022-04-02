using UnityEngine;

public class JobInfo : MonoBehaviour
{
    [Header("Description")]
    [TextArea(4,10)]
    public string jobDescription;
    [Space]
    public int payment;
    public float duration;
    public int hapinessLoss;
    public int minHapiness;
}
