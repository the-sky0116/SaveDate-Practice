using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor.Experimental.RestService;
using UnityEngine;
using UnityEngine.UI;

public class SaveData : MonoBehaviour
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
        if(Input.GetKeyDown(KeyCode.S))
        {
            FileStream fs = new FileStream(Application.dataPath + "/Save.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(data.name);
            sw.WriteLine(data.level);
            sw.WriteLine(data.Hp);
            sw.WriteLine(data.Mp);
            sw.Close();
            fs.Close();
            UiText.text = "儲存完成";
        }
        if(Input.GetKeyDown(KeyCode.L))
        {
            FileStream fs = new FileStream(Application.dataPath + "/Save.txt", FileMode.Open);
            StreamReader sr=new StreamReader(fs);
            data.name = sr.ReadLine();
            data.level=int.Parse(sr.ReadLine());
            data.Hp = int.Parse(sr.ReadLine());
            data.Mp = int.Parse(sr.ReadLine());
            UiText.text = "載入完成";
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
