using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MudarValor))]
public class EditorCustom : Editor
{
    int value;
    int index;
   
    public override void OnInspectorGUI()
    {
        MudarValor MudarValor = target as MudarValor;
        
        value = EditorGUILayout.IntField("Valor", value);
        if (GUILayout.Button("Acrescentar"))
        {
            MudarValor.Add(MudarValor.List.Count.ToString(), value);
        }
        EditorGUI.EndDisabledGroup();
        EditorGUILayout.LabelField("Remover", EditorStyles.boldLabel);
        index = EditorGUILayout.IntField("Valor", index);
        if (GUILayout.Button("Remover"))
        {
            MudarValor.Remove(index);
        }
        EditorGUI.BeginDisabledGroup(true);
        EditorGUILayout.LabelField("Lista", EditorStyles.boldLabel);
        
        for (int i = 0; i < MudarValor.List.Count; i++)
        {
            EditorGUILayout.FloatField(MudarValor.List[i].key, MudarValor.List[i].value);
        }  
        EditorGUILayout.LabelField("Acrescentar", EditorStyles.boldLabel);
       
        //MC Lessinha
        
    }
}
