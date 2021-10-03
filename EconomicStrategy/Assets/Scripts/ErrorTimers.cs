using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorTimers : MonoBehaviour
{
    [SerializeField] private GameObject ErrorPanel;
    public float TimerMaxTime;
    public float TimerCurrentTime;

    private void Start()
    {
        TimerCurrentTime = TimerMaxTime;
    }

    void Update()
    {
        if (ErrorPanel.activeInHierarchy == true)
        {
            Debug.Log("Должен вычитать");
            TimerCurrentTime -= Time.deltaTime;
            if (TimerCurrentTime <= 0)
            {
                ErrorPanel.SetActive(false);
                TimerCurrentTime = TimerMaxTime;
            }
        }
    }
}
