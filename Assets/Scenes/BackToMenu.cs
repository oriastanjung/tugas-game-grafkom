using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public void backToMMenu()
    {
        Debug.Log("Back To Menu");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }
}
