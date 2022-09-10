using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Mover : MonoBehaviour
{
    public TextAsset valueJson;
    int Score;
    [SerializeField] private TMP_Text ScoreText;

    public class Player
    {

    }

    [SerializeField] float MoveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Started");
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        PlayerDeath();
    }

    void MovePlayer()
    {
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * MoveSpeed;
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * MoveSpeed;
        transform.Translate(xValue,0,zValue);
    }

    void PlayerDeath()
    {
        if(gameObject.transform.position.y <= -1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }

    private void OnCollisionEnter(Collision other) {
        if(true)
        {
            Score += 1;
            ScoreText.text = Score.ToString();
        }
    }
}