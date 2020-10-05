using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    [SerializeField] private GameObject ObstacleSpawner;
    [SerializeField] private GameObject LoseMenu;
    [SerializeField] private GameObject timerObject;
    [SerializeField] private GameObject music;
    [SerializeField] private AudioSource explosionSound;
    [SerializeField] private GameObject explosionParticles;
    public bool hasDied = false;


    private void Awake()
    {
        explosionSound = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            hasDied = true;
            Destroy(collision.gameObject);

            ObstacleSpawner.SetActive(false);
            GetComponent<CarMovement>().enabled = false;
            timerObject.GetComponent<Timer>().enabled = false;
            if (PlayerPrefs.GetFloat("Score", 0) < timerObject.GetComponent<Timer>().t)
            {
                PlayerPrefs.SetFloat("Score", timerObject.GetComponent<Timer>().t);
            }
            music.SetActive(false);
            explosionSound.Play();
            StartCoroutine(CarDissapear());
            LoseMenu.SetActive(true);
            //SceneManager.LoadScene(0);
        }
    }

    IEnumerator CarDissapear()
    {
        explosionParticles.SetActive(true);
        yield return new WaitForSeconds(1.20f);
        GetComponent<SpriteRenderer>().enabled = false;
    }
}
