using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] AudioClip _startingSong = null;
    [SerializeField] Text _highScoreTextView = null;

    // Start is called before the first frame update
    void Start()
    {
        // load high score display
        int highscore = PlayerPrefs.GetInt("HighScore");
        _highScoreTextView.text = highscore.ToString();

        // play starting song on Menu Start
        if(_startingSong != null)
        {
            AudioManager.Instance.PlaySong(_startingSong);
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
