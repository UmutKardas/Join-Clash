using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerUIController : MonoBehaviour
{

    [SerializeField] private GameObject gameover;
    [SerializeField] private GameObject restartButton;
    [SerializeField] private PlayerMovementController playerMovementController;
    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;
    [SerializeField] private GameObject sogood;
    public bool lvlFinish = false;


    private void Start()
    {
        Time.timeScale = 1;
    }



    public void SetPlayerDeadUIController()
    {
        gameover.SetActive(true);
        restartButton.SetActive(true);
        Time.timeScale = 0;
    }



    public void SetLevelFinish()
    {
        lvlFinish = true;
        sogood.SetActive(true);
        playerMovementController.enabled = false;
        playerDataTransmitter.PlayFinishParticleEffectActive();
    }



    public void RestartButton()
    {
        SceneManager.LoadScene(0);
    }

}
