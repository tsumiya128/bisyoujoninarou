using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour
{
  //　回転スピード
  void Start () {
  }

  // Update is called once per frame
  void Update () {

      //画面をタッチしたらメインシーンをロード
      if (Input.touchCount > 0 ){
        SceneManager.LoadScene("main");
      }
    }
}