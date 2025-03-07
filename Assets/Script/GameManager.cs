using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject ballPrefabs;
    public int timeDuration;
    public int score = 0;
    public Text textPanel;
    public GameObject gameOver;
    public GameObject pause;
    public bool check = false;
    // Start is called before the first frame update
    void Start()
    {
        timeDuration = 50;
        gameOver.SetActive(false);
        textPanel.text = "Diem : " + 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (check == false)
        {
            Create();
        }
    }

    public void Create()
    {

        if (timeDuration == 50)
        {
            GameObject ball = Instantiate(ballPrefabs, new Vector3(UnityEngine.Random.Range(-6.7f, 6.7f), 6f), Quaternion.identity);
            timeDuration = 0;
        }
        else
        {
            timeDuration += 1;
        }
    }

    public void Score()
    {
        score++;
        textPanel.text = "Diem : " + score.ToString();
    }
}
