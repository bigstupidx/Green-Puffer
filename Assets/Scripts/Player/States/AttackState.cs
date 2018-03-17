using UnityEngine;
using E7;

class AttackState : IState
{
	SpeechBubble bubble;
	private float elapsed = 0;

	public void Begin(PlayerStateMachine owner)
	{
		bubble = SpeechBubbleManager.instance.CreateBubble(0, Localization.GetString("attack"));
		bubble.Attach(owner.transform);
		bubble.SetEffect(SpeechBubble.Effect.None);
	}

	public void Update(PlayerStateMachine owner)
	{
		if ((elapsed += Time.deltaTime) > 3)
		{
			owner.Change(new NormalState());
		}
	}

	public void End(PlayerStateMachine owner)
	{
		bubble.Destory();
	}
}