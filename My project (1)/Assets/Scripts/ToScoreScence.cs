using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ToScoreScence : MonoBehaviour
{
    void Start()  // ���UStart���s�A������C������
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
    }
    void OnClick()
    {
        SceneManager.LoadScene("score");
    }
}
