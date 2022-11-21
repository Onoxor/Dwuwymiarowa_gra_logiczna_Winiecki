using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(NextLevelTrigger))]
[CanEditMultipleObjects]
public class NextLeveleditor : Editor
{

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        Rect labelRect = GUILayoutUtility.GetRect(new GUIContent("1. altruism\r\n2. conformism\r\n3. rationalism\r\n4. courage\r\n5. selfishnes\r\n6. nonconformism\r\n7. empyrism\r\n8. cowardice"), "label");
        GUI.Label(labelRect, "1. altruism\r\n2. conformism\r\n3. rationalism\r\n4. courage\r\n5. selfishnes\r\n6. nonconformism\r\n7. empyrism\r\n8. cowardice");
    }
}