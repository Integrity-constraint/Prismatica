
using System.Runtime;
using UnityEditor;

[CustomEditor(typeof(Interactble), true)]
public class InteractbleEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Interactble interactble = (Interactble)target;
        if(target.GetType() == typeof(EventOnlyInteractble))
        {
            interactble.promptMessage = EditorGUILayout.TextField("Prompt message", interactble.promptMessage);

            EditorGUILayout.HelpBox("Ивент онли, работает только с системой ивентов", MessageType.Info);

            if(interactble.GetComponent<InteractionEvent>() == null)
            {
                interactble.useEvents = true;
                interactble.gameObject.AddComponent<InteractionEvent>();
            }
        }
        else
        {
            base.OnInspectorGUI();
            if (interactble.useEvents)
            {
                if (interactble.GetComponent<InteractionEvent>() == null)
                {
                    interactble.gameObject.AddComponent<InteractionEvent>();
                }

            }
            else
            {
                if (interactble.GetComponent<InteractionEvent>() != null)
                {
                    DestroyImmediate(interactble.GetComponent<InteractionEvent>());
                }

            }
        }
       
    }
}
