using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    private void Awake() {
        DontDestroyOnLoad(gameObject);
        ConnectViaCode.Instance.ConnectSuccess += ConnectSuccess;
    }

    private void ConnectSuccess() {
        SceneManager.LoadSceneAsync($"GameScene");
    }
}