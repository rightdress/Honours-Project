using UnityEngine;
using UnityEngine.Events;

public class ActionTrigger : MonoBehaviour
{
    public UnityEvent OnComplete;

    protected void Complete()
    {
        OnComplete?.Invoke();
    }
}
