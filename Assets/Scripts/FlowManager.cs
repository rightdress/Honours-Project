using UnityEngine;

public class FlowManager : MonoBehaviour
{
    [SerializeField] private GameObject[] screens;
    private int curScreenIndex = 0;

    void Start()
    {
        // Hide all screens
        for (int i = 0; i < screens.Length; i++)
        {
            screens[i].SetActive(false);
        }

        ShowScreen(curScreenIndex);
    }

    void ShowScreen(int index)
    {
        for (int i = 0; i < screens.Length; i++)
        {
            if (i == index)
            {
                screens[i].SetActive(true);
            }
        }

        var action = screens[index].GetComponent<ActionTrigger>();
        if (action != null)
        {
            action.OnComplete.AddListener(NextScreen);
        }
    }

    void NextScreen()
    {
        var curScreen = screens[curScreenIndex].GetComponent<ActionTrigger>();
        if (curScreen != null)
        {
            curScreen.OnComplete.RemoveListener(NextScreen);
        }

        curScreenIndex++;

        if (curScreenIndex < screens.Length)
        {
            ShowScreen(curScreenIndex);
        }
    }

}
