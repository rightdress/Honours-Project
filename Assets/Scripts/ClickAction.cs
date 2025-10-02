using UnityEngine;

public class ClickAction : ActionTrigger
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Complete();
        }
    }
}
