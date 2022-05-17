using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class CheckIfEndGame : MonoBehaviour
{
    [SerializeField] private PlayerStats player;
    [SerializeField] private PlayableDirector sCine;
    [SerializeField] private GameObject playerObject;
    [SerializeField] private GameObject brokenShip;
    [SerializeField] private GameObject rebuildedShip;
    [SerializeField] private GameObject cineCamera;
    private AudioSource musicM;

    private void Start()
    {
        musicM = MusicManager.instance.gameObject.GetComponent<AudioSource>();
        if(player.GotMarcPiece && player.GotSebPiece && player.GotStevenPiece)
        {
            StartCoroutine(StartCine());
        }
    }
    private IEnumerator StartCine()
    {
        musicM.Pause();
        playerObject.SetActive(false);
        brokenShip.SetActive(false);
        rebuildedShip.SetActive(true);
        cineCamera.SetActive(true);
        sCine.Play();
        yield return new WaitForSeconds((float)sCine.duration);
        player.LastCheckpoint = Vector3.zero;
        player.GotMarcPiece = false;
        player.GotSebPiece = false;
        player.GotStevenPiece = false;
        musicM.UnPause();
        SceneManager.LoadScene("MainMenu");
    }
}
