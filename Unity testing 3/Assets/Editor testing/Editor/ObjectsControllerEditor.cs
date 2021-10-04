using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ObjectsController))]
public class ObjectsControllerEditor : Editor
{
    List<string> textFieldText;
    int space = 0;
    string textToAdd = "";

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        ObjectsController objController = (ObjectsController) target;

        float val = 4f;

        GUILayout.BeginHorizontal();

        if (GUILayout.Button($"Send value: {val}"))
        {
            Debug.Log("Before");
            objController.SendMessage("PrintValue", val);
            Debug.Log("After");
        }
        GUILayout.Button("Another button");

        GUILayout.EndHorizontal();

        ///////////////

        GUILayout.Space(20);

        space = (int)GUILayout.HorizontalSlider(space, 0f, 100f);
        GUILayout.Space(10);
        GUILayout.Label($"{space}");

        ///////////////

        GUILayout.Space(20);

        GUILayout.BeginHorizontal();

        GUILayout.Label("String to add: ");

        textToAdd = GUILayout.TextField(textToAdd);

        if (GUILayout.Button("Add string"))
        {
            textFieldText.Add(textToAdd);
        }
        GUILayout.Space(space);
        if (GUILayout.Button("Remove string") && textFieldText.Count > 0)
        {
            textFieldText.RemoveAt(textFieldText.Count - 1);
        }

        GUILayout.EndHorizontal();

        for (int i = 0; i < textFieldText.Count; i++)
        {
            textFieldText[i] = GUILayout.TextField(textFieldText[i]);
        }

        GUILayout.BeginHorizontal();

        foreach (string text in textFieldText) 
            GUILayout.Label(text);

        GUILayout.EndHorizontal();

        ///////////////

        GUILayout.Space(20);

        GUILayout.BeginHorizontal();

        GUILayout.Label("This is a label");
        GUILayout.Label("This is another label");

        GUILayout.EndHorizontal();
    }
}
