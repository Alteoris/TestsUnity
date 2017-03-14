using UnityEngine;

public class Hit : MonoBehaviour
{
    public Transform NextTarget;

    void OnTriggerEnter(Collider other)
    {
        MoveTo.Instance.ChangeTarget(NextTarget);
    }
}
