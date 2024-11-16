using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using OpenBLive.Runtime.Data;
using TMPro;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour {
    [SerializeField] TMP_Text _lastInput;

    void Start() {
        ConnectViaCode.Instance.OnDanmaku += OnDanmaku;
    }

    private void OnDanmaku(Dm dm) {
        switch (dm.msg) {
            case "w":
                transform.DOMove(transform.position + Vector3.up, 0.5f);
                _lastInput.text = "up";
                break;
            case "s":
                transform.DOMove(transform.position + Vector3.down, 0.5f);
                _lastInput.text = "down";
                break;
            case "a":
                transform.DOMove(transform.position + Vector3.left, 0.5f);
                _lastInput.text = "left";
                break;
            case "d":
                transform.DOMove(transform.position + Vector3.right, 0.5f);
                _lastInput.text = "right";
                break;
            case "r":
                transform.DOMove(Vector3.zero, 0.5f);
                _lastInput.text = "reset";
                break;
        }
    }
}