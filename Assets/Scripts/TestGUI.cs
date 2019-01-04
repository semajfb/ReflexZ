using UnityEngine;
using System.Collections;

public class TestGUI : MonoBehaviour {

    private BaseCharacterClass class1 = new BaseCleric();
    private BaseCharacterClass class2 = new BaseMage();

    void Start()
    {
    
    }

     void Update()
    {
        
    }

    private void OnGUI()
    {
        GUILayout.Label(class1.ClassName);
        GUILayout.Label(class1.Agility.ToString());
        GUILayout.Label(class1.ClassName);


        GUILayout.Label(class2.Agility.ToString());
    }
}
