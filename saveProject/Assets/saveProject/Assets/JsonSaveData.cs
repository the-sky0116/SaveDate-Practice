using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class JsonSaveData : MonoBehaviour
{
    [SerializeField]
    Text UiText;
    [SerializeField]
    PlayerData data;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            PlayerPrefs.SetString("JsonData", JsonUtility.ToJson(data));
            UiText.text = "�x�s����";
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            data = JsonUtility.FromJson<PlayerData>(PlayerPrefs.GetString("JsonData"));
            UiText.text = "���J����";
        }
    }
    [System.Serializable]
    public class PlayerData
    {
        public string name;
        public int level;
        public int Hp;
        public int Mp;
    }
}
