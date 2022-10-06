using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    private GameObject CarController;
    float currentTime = 0f;
    float startingTime = 3f;

     [SerializeField] Text countdownText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;

    }

    void update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            
            CarController.SetActive(true);
        }
    }
}