using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public ItemBox[] itemBoxes;
    public bool isGameOver;
    public GameObject WinUI;
    public AudioSource soundEffect;
    void Start()
    {
        isGameOver=false;
    }

    // Update is called once per frame
    void Update()
    {  if (Input.GetKeyDown(KeyCode.Space))
            SceneManager.LoadScene(0);
        if (isGameOver == true) return;

        int count = 0;
        for (int i = 0; i < 3; i++)
        {
            if (itemBoxes[i].check == true)
                count++;
        }

        if (count >= 3)
        {
            isGameOver = true;
            WinUI.SetActive(true);
            soundEffect.Play();
        }
    }
}
