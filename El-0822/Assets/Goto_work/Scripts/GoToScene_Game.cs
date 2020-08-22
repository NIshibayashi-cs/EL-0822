using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToScene_Game : MonoBehaviour
{
    private string gameSceneName = "game";
    // Start is called before the first frame update
    public void OnClick()
    {
        Debug.Log("StageSelectButton クリック。");

        // ボタンの色を変える
        gameObject.GetComponent<Image>().color = Color.cyan;

        // ゲームシーンの非同期ロード開始    
        Debug.Log("ゲームシーンの非同期読込開始。");
        SceneManager.LoadSceneAsync(gameSceneName);
    }
}
