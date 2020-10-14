using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
  
        [SerializeField] private GameObject pauseMenuUI = null;

        [SerializeField] private bool isPaused;


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                isPaused = !isPaused;
            }

            if (isPaused)
            {
                ActivateMenu();
            }

            else
            {
                DeactivateMenu();
            }

        }

        void ActivateMenu()
        {
            
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0;
        AudioListener.pause = true;
            Cursor.lockState = CursorLockMode.None;
        }

        void DeactivateMenu()
        {
            pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        AudioListener.pause = false;
        Cursor.lockState = CursorLockMode.Locked;
        }

    

}
