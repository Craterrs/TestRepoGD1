using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class KillFloor : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawn_point;

    private void OnTriggerEnter(Collider other)
    {
        //player.transform.position = respawn_point.transform.position;
        SceneManager.LoadScene("pittzy", LoadSceneMode.Single);
        
    }
}
