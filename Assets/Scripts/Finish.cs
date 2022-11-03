using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
  //  public GameObject player;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Win!");
       // Destroy(player, 1f);
    }
    //private void ReloadLevel()
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    //}
}
