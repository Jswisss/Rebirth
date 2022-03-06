//Ronald Ison
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/State")]
public class State : ScriptableObject
{
    public Action[] actions;
    public Transition[] transitions;
    public Color sceneGizmoColor = Color.grey;

    public void UpdateState(AdversaryAITemplate adversary)
    {
        DoActions(adversary);
        CheckTransitions(adversary);
    }

    private void DoActions(AdversaryAITemplate adversary)
    {
        for (int i = 0; i < actions.Length; i++)
        {
            actions[i].Act(adversary);
        }
    }

    private void CheckTransitions(AdversaryAITemplate adversary)
    {
        for (int i = 0; i < transitions.Length; i++)
        {
            bool decisionSuccedeed = transitions[i].decision.Decide(adversary);
            if(decisionSuccedeed)
            {
                adversary.TransitionToState(transitions[i].trueState);
            }
            else
            {
                adversary.TransitionToState(transitions[i].falseState);
            }
        }
    }
}
